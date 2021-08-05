using System;
using System.Collections.Generic;
using System.Text;

namespace KateFirebird
{
    [TableName("Breeds")]
    public class Breed 
    {
        public int Id;
        public string Name;
        public float? AvgProduction;
        public float? AvgWeight;
        public int? DietId;

        public static Breed GetRandom(int count, int dietCount)
        {
            var r = new Random();
            return new Breed()
            {
                Id = count++,
                Name = "breed " + count++,
                AvgProduction = r.Next(0, 10),
                AvgWeight = r.Next(0, 10),
                DietId = r.Next(1, dietCount)
            };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
