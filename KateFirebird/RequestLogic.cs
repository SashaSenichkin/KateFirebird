using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KateFirebird
{
    static class RequestLogic
    {
        /// <summary>
        /// количество яиц получаемое от курицы данного веса, породы, возраста;
        /// </summary>
        /// <param name="data"></param>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public static IEnumerable<Chicken> GetEggsCountByParams(IDataProvider data, float weightFrom, float weightTo, int breedId, int age )
        {
            return data.Chickens.Where(x =>    x.Weight >= weightFrom 
                                            && x.Weight <= weightTo
                                            && x.BreedId == breedId 
                                            && x.Age == age);
        }

        /// <summary>
        ///  цех, с наибольшим количеством кур определенной породы;
        /// </summary>
        /// <param name="data"></param>
        /// <param name="breedId"></param>
        /// <returns></returns>
        public static int? GetDepartmentWithBreed(IDataProvider data, int breedId)
        {
            //Fail Icomparable req
            return data.Cells.Join(data.Chickens.Where(x => x.BreedId == breedId), x => x.Id, x => x.CellId, (x, y) => x)
                                               .GroupBy(x => x.DepartmentNum)
                                               .Max()
                                               .FirstOrDefault()?.DepartmentNum;
        }


        /// <summary>
        /// в каких клетках сидят двухлетние куры с диетой номер 2
        /// </summary>
        /// <param name="data"></param>
        /// <param name="age"></param>
        /// <param name="dietId"></param>
        /// <returns></returns>
        public static IEnumerable<Cell> GetCellByAgeAndDiet(IDataProvider data, int age, int dietId)
        {
            var fitBreeds = data.Breeds.Where(x => x.DietId == dietId).Select(x => x.Id); //fitBreeds
            return data.Cells.Join(data.Chickens.Where(x => fitBreeds.Any(y => y == x.BreedId) && x.Age >= age), x => x.Id, x => x.CellId, (x, y) => x);
        }

        /// <summary>
        /// сколько яиц в день приносят куры указанной работницы
        /// </summary>
        /// <param name="data"></param>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public static int? GetEggsCountByWorker(IDataProvider data, int workerId)
        {
            return data.Chickens.Where(x => data.Cells.FirstOrDefault(y => y.Id == x.CellId && y.WorkerId == workerId) != null).Sum(x => x.EddCount);
        }

        /// <summary>
        /// в каком цехе находится клетка, из которой получают больше всего яиц.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public static int? GetDepartmentWithMaxEggs(IDataProvider data)
        {
            var maxEggsCell = data.Chickens.OrderByDescending(x => x.EddCount).ToList().FirstOrDefault();
            return data.Cells.FirstOrDefault(x => x.Id == maxEggsCell?.Id)?.DepartmentNum;
        }

        /// <summary>
        /// выдачи справки о номере диеты для курицы указанной породы
        /// </summary>
        /// <param name="data"></param>
        /// <param name="breedId"></param>
        /// <returns></returns>
        public static int? GetDietByBreedId(IDataProvider data, int breedId)
        {
            return data.Breeds.First(x => x.Id == breedId).DietId;
        }
    }
}
