﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KateFirebird
{
    public class Chicken
    {
        public int Id;
        public float? Weight;
        public int? Age;
        public int? BreedId;
        public int EddCount;
        public int? CellId;

        public static Chicken GetRandom(int count, int breedCount, int cellCount)
        {
            var r = new Random();
            return new Chicken()
            {
                Id = count++,
                Weight = r.Next(0, 10),
                Age = r.Next(0, 10),
                BreedId = r.Next(0, breedCount + 1),
                EddCount = r.Next(0, 10),
                CellId = r.Next(0, cellCount + 1),
            };
        }
    }
}