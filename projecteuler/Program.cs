using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AnswerQuestion1(1000));
            Console.ReadKey();
        }

        /// <summary>
        /// https://projecteuler.net/problem=1
        /// </summary>
        /// <returns></returns>
        static int AnswerQuestion1(int upLimit)
        {
            int ret = 0;
            for (int i = 3; i < upLimit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    ret += i;
                }
            }
            return ret;
        }
    }
}
