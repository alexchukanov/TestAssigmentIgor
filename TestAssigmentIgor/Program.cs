using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssigmentIgor
{
    //Task description:
    //You’ve an array of numbers [1,2,4,5,6,8].
    //Please, find “3” and "7" and so on using LINQ.
    internal class Program
    {
        static List<int> list = new List<int> {1, 2, 4, 5, 6, 8};
        
        static void Main(string[] args)
        {
            int i = 1;
            list.ForEach(x =>
                    {
                        if (x != i)
                        {
                            Console.Write(i + " ");
                            i++;
                        }                       
                        i++;                        
                    });
            Console.ReadLine();
        }
    }
}
