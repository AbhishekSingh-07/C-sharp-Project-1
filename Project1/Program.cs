using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            Console.WriteLine("Enter rows and cols");
            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());

            int n;
            int[,] a = new int[rows, cols];

            for (int i = 0; i<rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (i== rows-1 && k==0)
                    {
                        Console.WriteLine("1" + " ");
                    }
                    else
                    {
                        Console.Write("0" + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
