using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] studMarks = new int[4, 6];


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Students {i + 1}\'s Roll Number");
                studMarks[i, 0] = int.Parse(Console.ReadLine());

                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine($"Enter marks of Student\'s {i + 1} in Sem {j}");
                    studMarks[i, j] = int.Parse(Console.ReadLine());
                    
                }

                
            }
            

            Console.Write("Rollno\tSem1\tSem2\tSem3\tSem4\tTotal\n");
            for (int i = 0; i < 4; i++)
            {
                int total = 0;
                               
                for (int j = 0; j < 5; j++)
                {

                    Console.Write(studMarks[i, j]+" \t");

                    if (j > 0)
                    {
                        total += studMarks[i, j];
                    }
                    
                    
                }
                Console.Write(total);
                Console.WriteLine("\n");
            }

            Console.ReadKey();


        } 
    }
}
