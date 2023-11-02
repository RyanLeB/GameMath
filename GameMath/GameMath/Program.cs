using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace GameMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monte Carlo Simulation");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to start");
            Console.ReadKey(true);
            
            
            // while loop
            // arrays

            int count;
            count = 0;

            int[] amounts = new int[12]; // 0...11 --> 1...12 results (2d6 rolls)
            Random rng = new Random();


            while (Console.KeyAvailable == false) // infinite loop
            {
                int dice1 = rng.Next(1, 7); // 1...6 
                int dice2 = rng.Next(1, 7); // 1...6
                Debug.Assert(dice1 >= 1);
                Debug.Assert(dice1 <= 6);
                Debug.Assert(dice2 >= 1);
                Debug.Assert(dice2 <= 6);

                int result = dice1 + dice2; // 2...12 (range 1...12)
                Debug.Assert(result >= 2);
                Debug.Assert(result <= 12);

                amounts[result - 1]++;

                count = count + 1;
                
                
                Console.WriteLine("Dice roll #"+ count + ": ");
                for (int i = 0; i <= 11; i++) 
                { 
                    Console.WriteLine((i + 1) + ": " + amounts[i]);
                }
            }
            Console.ReadKey(true);
                    

                      
    
            
            



            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
