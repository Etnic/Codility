using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.BinaryGap
{
    public static class BinaryGap
    {
        public static int solution(int N)
        {
            var binaryNumber = Convert.ToString(N, 2).ToCharArray();
            var counter = 0;
            var list = new List<int>();

            for (int i = 1; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '1')
                {
                    list.Add(counter);
                    counter = 0;
                    continue;
                }

                counter++;
            }

            if (list.Count() == 0)
                list.Add(0); 
                    
            return list.Max();
        }
    }
}
