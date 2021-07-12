using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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

            for (int i = 0; i < 10; i++)
                Breeds.Add(Breed.GetRandom(i, DietCount));

            for (int i = 0; i < 100; i++)
            {
                var cell = Cell.GetRandom(i, Workers.Count);
                Cells.Add(cell);
                Chickens.Add(Chicken.GetRandom(i, Breeds.Count, cell.Id));
            }
        }

        public void AddChicken(Chicken chicken)
        {
            Chickens.Add(chicken);
        }

        public void DeleteWorker(int id)
        {
            Workers.RemoveAll(x => x.Id == id);
        }

        public void UpdateChickenWeight(int id, float newWeight)
        {
            Chickens.First(x => x.Id == id).Weight = newWeight;
        }
    }
}
