using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KateFirebird
{
    interface IDataProvider
    {
        List<Breed> Breeds { get; set; }
        List<Cell> Cells { get; set; }
        List<Chicken> Chickens { get; set; }
        List<Worker> Workers { get; set; }

        void AddChicken(Chicken chicken);
        void DeleteWorker(int id);
        void UpdateChickenWeight(int selectedId, float newWeight);
    }
}
