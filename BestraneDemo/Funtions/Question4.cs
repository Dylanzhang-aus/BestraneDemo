using System;
using System.Collections.Generic;

namespace BestraneDemo.Funtions
{
    public class Question4
    {
        public int Method(List<int> AList)
        {
            int result = 0;

            List<int> NList = new();

            for(int i = 1; i <=100000; i++)
            {
                NList.Add(i);
            }

            foreach(var number in NList)
            {
                if (!AList.Contains(number))
                {
                    result = number;
                    break;
                }
            }

            //if no found, return 0 as result.
            return result;
        }
    }
}
