using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingValues
{
    public static class FindMissingNumber
    {

        //I thought at first we are looking missing number between two numbers(min,max) of List of Int
        //public static List<int> FindMissing(List<int> myList) 
        //{ 
        //    var founded = new List<int>();
        //    if(myList == null || myList.Count == 0)
        //    {
        //        throw new ArgumentNullException(nameof(myList));
        //    }
 
        //    var maxNum = myList.Max(x => x);
        //    var minNum = myList.Min(x => x);
 
        //    for (int i = minNum; i < maxNum - 1; i++)
        //    {
        //        var temp = i + 1;
        //        bool isExist = myList.Contains(temp);
        //        if (!isExist)
        //        {
        //            founded.Add(temp);
        //        }
        //    }
        //    return founded;
        //}

        //this is the range between two numbers..
        public static IEnumerable<int> FindMissingRangedNumber(IEnumerable<int> myList)
        {
            var founded = new List<int>();
            if (myList == null || myList.Count() == 0)
                throw new ArgumentNullException(nameof(myList));
            
            var maxNum = myList.Max(x => x);
            var minNum = myList.Min( x => x);

            //if i want to use range
            var findRange = Enumerable.Range(minNum, maxNum); //Nice is using these

            //if I don't want to use range
            for(int i= minNum; i<maxNum+minNum; i++) //shanaz approach.
            {
                if (!myList.Contains(i))
                { 
                    founded.Add(i); 
                    continue;
                }
            }


            return founded;
        }
    }
}
