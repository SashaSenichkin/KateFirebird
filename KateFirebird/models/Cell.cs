using System;
using System.Collections.Generic;
using System.Text;

namespace KateFirebird
{
    public class Cell
    {
        public int Id;
        public int? WorkerId;
        public int? CellNum;
        public int? RowNum;
        public int? DepartmentNum;

        public static Cell GetRandom(int count, int workerCount)
        {
            var r = new Random();
            return new Cell()
            {
                Id = count++,
                WorkerId = r.Next(1, workerCount),
                CellNum = r.Next(1, 10),
                RowNum = r.Next(1, 10),
                DepartmentNum = r.Next(1, 10)
            };
        }
    }
}
