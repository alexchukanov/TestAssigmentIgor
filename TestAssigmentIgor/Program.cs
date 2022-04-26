using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssigmentIgor
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            //TASK 1
            //You’ve an array of numbers [1,2,4,5,6,8].
            //Please, find “3” and "7" and so on using LINQ.

            List<int> list = new List<int> { 1, 2, 4, 6, 8 };

            Console.WriteLine("TASK 1");

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

            Console.WriteLine();

            //TASK 2
            //You have a tree table / array of structs with two columns / fields, the first one lists the nodes and the second one lists the parent nodes.

            /*
                node parent
                1       2
                2       5
                3       5
                4       3
                5       NULL

                Write SQL / algorithm in such a way that we designate each node as inner (inner), root(root), or leaf node(leaf), so that for the above values, the following will turn out:


                node    label
                1       Leaf
                2       Inner
                3       Inner
                4       Leaf
                5       Root
            */

            List<int> parent = new List<int> { 2, 5, 5, 3, 0 };

            Console.WriteLine();
            Console.WriteLine("TASK 2");

            i = 0;
            parent.ForEach(x =>
            {
                if (parent[i] == 0)
                {
                    Console.WriteLine((i + 1) + " Root");
                }
                else if (!parent.Contains(i + 1))
                {
                    Console.WriteLine((i + 1) + " Leaf");
                }
                else
                {
                    Console.WriteLine((i + 1) + " Inner");
                }
                i++;
            });

            Console.ReadLine();
        }
    }
}
