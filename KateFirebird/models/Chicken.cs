using System;
using System.Collections.Generic;
using System.Text;

namespace KateFirebird
{
    [TableName("Chickens")]
    public class Chicken
    {
        public int Id;
        public float? Weight;
        public int? Age;
        public int? BreedId;
        public int EggCount;
        public int? CellId;

        public static Chicken GetRandom(int count, int breedCount, int cellId)
        {
            var r = new Random();
            return new Chicken()
            {
                Id = count++,
                Weight = r.Next(2, 10),
                Age = r.Next(0, 3),
                BreedId = r.Next(1, breedCount),
                EggCount = r.Next(2, 10),
                CellId = cellId,
            };
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
