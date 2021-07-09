using System;
using System.Collections.Generic;
using System.Text;

namespace KateFirebird
{
    interface IDataProvider
    {
        List<Breed> Breeds { get; set; }
        List<Cell> Cells { get; set; }
        List<Chicken> Chickens { get; set; }
        List<Worker> Workers { get; set; }

    }
}
