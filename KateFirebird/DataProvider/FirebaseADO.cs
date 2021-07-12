using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KateFirebird
{
    public class FirebaseADO : IDataProvider
    {
        OleDbConnection Connection;
        public List<Breed> Breeds { get; set; }
        public List<Cell> Cells { get; set; }
        public List<Chicken> Chickens { get; set; }
        public List<Worker> Workers { get; set; }

        public FirebaseADO()
        {
            OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
            cb.Provider = "LCPI.IBProvider";
            cb.Add("Location", @"localhost: d:\Program Files\Firebird\examples\CHICKENFARM.FDB");
            cb.Add("User ID", "sysdba");
            cb.Add("Password", "masterkey");
            cb.Add("ctype", "win1251");

            Connection = new OleDbConnection(cb.ToString());
            UpdateTables();
        }

        private void UpdateTables()
        {
            Connection.Open();
            var trans = Connection.BeginTransaction();
            var cmdChick = new OleDbCommand("select Id, Weight, Age, BreedId, EggCount, CellId from Chickens", Connection, trans);
            Chickens = cmdChick.ExecuteReader().Cast<Chicken>().ToList();

            var cmdCells = new OleDbCommand("select Id, DepartmentNum, RowNum, CellNum, WorkerId from Cells", Connection, trans);
            Cells = cmdCells.ExecuteReader().Cast<Cell>().ToList();

            var cmdWorkers = new OleDbCommand("select Id, FullName, Salary from Workers", Connection, trans);
            Workers = cmdWorkers.ExecuteReader().Cast<Worker>().ToList();

            var cmdBreeds = new OleDbCommand("select Id, Name, AvgProduction, AvgWeight, DietId from Breeds", Connection, trans);
            Breeds = cmdBreeds.ExecuteReader().Cast<Breed>().ToList();

            Connection.Close();
        }

        public void AddChicken(Chicken chicken)
        {
            Connection.Open();
            var trans = Connection.BeginTransaction();
            var cmdChick = new OleDbCommand($"insert into Chickens values({chicken.Id}, {chicken.Weight}, {chicken.Age}, {chicken.BreedId}, 0, {chicken.CellId})", Connection, trans);
            cmdChick.ExecuteNonQuery();
            Connection.Close();
            UpdateTables();
        }

        public void DeleteWorker(int id)
        {
            Connection.Open();
            var trans = Connection.BeginTransaction();
            var cmdChick = new OleDbCommand($"Delete from workers where Id = {id})", Connection, trans);
            cmdChick.ExecuteNonQuery();
            Connection.Close();
            UpdateTables();
        }

        public void UpdateChickenWeight(int id, float newWeight)
        {
            Connection.Open();
            var trans = Connection.BeginTransaction();
            var cmdChick = new OleDbCommand($"update Chickens set Weight = {newWeight} where id = {id})", Connection, trans);
            cmdChick.ExecuteNonQuery();
            Connection.Close();
            UpdateTables();
        }
    }
}
