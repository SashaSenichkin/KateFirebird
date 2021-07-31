using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace KateFirebird
{
    public class FirebaseADO : IDataProvider
    {
        FbConnection Connection;
        public List<Breed> Breeds { get; set; }
        public List<Cell> Cells { get; set; }
        public List<Chicken> Chickens { get; set; }
        public List<Worker> Workers { get; set; }

        public FirebaseADO()
        {
            var cb = new StringBuilder();
            cb.Append("User=SYSDBA;");
            cb.Append("Password=111;");
            cb.Append("DataSource=localhost;");
            cb.Append("Database=KATEFIREBIRD.fdb;");

            var t = new FbConnectionStringBuilder();
            t.Database = @"E:\Git\KateFirebird\Db\KATEFIREBIRD.FDB";
            t.DataSource = "localhost";
            t.Password = "111";
            t.UserID = "SYSDBA";
            t.Charset = "NONE";
            t.WireCrypt = FbWireCrypt.Enabled;
  
            Connection = new FbConnection(t.ToString());
            UpdateTables();
        }

        private void UpdateTables()
        {
            Workers = GetAllObjectsOfType<Worker>();
            Breeds = GetAllObjectsOfType<Breed>();
            Cells = GetAllObjectsOfType<Cell>();
            Chickens = GetAllObjectsOfType<Chicken>();
        }

        private List<T> GetAllObjectsOfType<T>() where T : new()
        {
            Connection.Open();
            var fields = String.Join(", ",GetFieldsNames<T>());
            var tableAttr = typeof(T).GetCustomAttributes(false).ToList().FirstOrDefault(x => x is TableNameAttribute);
            if (!(tableAttr is TableNameAttribute tableName))
                throw new Exception($"add TableNameAttribute to entity {typeof(T).Name}");

            var dbData = new FbCommand($"select {fields} from {tableName.TableName}", Connection);
            var reader = dbData.ExecuteReader();
            var values = new object[reader.FieldCount];
            var result = new List<T>();

            while (reader.Read())
            {
                reader.GetValues(values);
                result.Add(CastFromObjArray<T>(values));
            }

            Connection.Close();
            return result;
        }

        private string[] GetFieldsNames<T>() 
        {
            return typeof(T).GetFields().Select(x => x.Name).ToArray();
        }

        private T CastFromObjArray<T>(object[] values) where T: new()
        {
            var instance = new T();
            var fields = typeof(T).GetFields();
            for (int i = 0; i < values.Length; i++)
                fields[i].SetValue(instance, values[i]);

            return instance;
        }

        public void AddChicken(Chicken chicken)
        {
            Connection.Open();
            var trans = Connection.BeginTransaction();
            var cmdChick = new FbCommand($"insert into Chickens values({chicken.Id}, {chicken.Weight}, {chicken.Age}, {chicken.BreedId}, 0, {chicken.CellId})", Connection, trans);
            cmdChick.ExecuteNonQuery();
            Connection.Close();
            UpdateTables();
        }

        public void DeleteWorker(int id)
        {
            Connection.Open();
            var trans = Connection.BeginTransaction();
            var cmdChick = new FbCommand($"Delete from workers where Id = {id})", Connection, trans);
            cmdChick.ExecuteNonQuery();
            Connection.Close();
            UpdateTables();
        }

        public void UpdateChickenWeight(int id, float newWeight)
        {
            Connection.Open();
            var trans = Connection.BeginTransaction();
            var cmdChick = new FbCommand($"update Chickens set Weight = {newWeight} where id = {id})", Connection, trans);
            cmdChick.ExecuteNonQuery();
            Connection.Close();
            UpdateTables();
        }
    }
    public class TableNameAttribute : Attribute
    {
        public string TableName;
        public TableNameAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
}
