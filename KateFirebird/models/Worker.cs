using System;
using System.Collections.Generic;
using System.Text;

namespace KateFirebird
{
    public class Worker
    {
        public int Id;
        public string FullName;
        public float? Salary;

        public static Worker GetRandom(int count)
        {
            var r = new Random();
            return new Worker()
            {
                Id = count++,
                FullName = "worker Num " + count++,
                Salary = r.Next(0, 100)
            };
        }
    }
}
