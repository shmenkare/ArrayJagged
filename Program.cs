using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ArrayJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            
            string[][] Familias = new string[3][];

            Familias[0] = new string [4];
            Familias[1] = new string [3];
            Familias[2] = new string [2];

            Familias[0][0] = "Juan";
            Familias[0][1] = "Antonio";
            Familias[0][2] = "Maria";
            Familias[0][3] = "Karina";
            Familias[1][0] = "Laura";
            Familias[1][1] = "Peter";
            Familias[1][2] = "Jack";
            Familias[2][0] = "Alice";
            Familias[2][1] = "Neida";

            for (i = 0; i < 3; i++)
            {
                
                for (j = 0; j < Familias[i].Length; j++)
                {
                    Thread.Sleep(350);
                    Console.Write(Familias[i][j]+" ");
                
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }

    }
}
