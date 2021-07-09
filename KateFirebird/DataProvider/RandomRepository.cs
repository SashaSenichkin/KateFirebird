using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace KateFirebird
{
    public class RandomRata : IDataProvider
    {
        const int DietCount = 5;
        public List<Breed> Breeds { get; set; } = new List<Breed>();
        public List<Cell> Cells { get; set; } = new List<Cell>();
        public List<Chicken> Chickens { get; set; } = new List<Chicken>();
        public List<Worker> Workers { get; set; } = new List<Worker>();

        public RandomRata()
        {
            for (int i = 0; i < 20; i++)
              Workers.Add(Worker.GetRandom(i));

            for (int i = 0; i < 50; i++)
                Breeds.Add(Breed.GetRandom(i, DietCount));

            for (int i = 0; i < 100; i++)
            {
                var cell = Cell.GetRandom(i, Workers.Count);
                Cells.Add(cell);
                Chickens.Add(Chicken.GetRandom(i, Breeds.Count, cell.Id));
            }
        }
    }
}
