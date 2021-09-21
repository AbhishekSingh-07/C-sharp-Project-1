using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class puzzle
    {

        static int orderOfMatrix, currentIndex;
        static int[] arr;

        // SHIFTING METHODS
        //*****************   5    ***********************
        static void upShift2()
        {
            currentIndex = indexOf1();
            if ((currentIndex / orderOfMatrix) != 0)
            {
                arr[currentIndex - orderOfMatrix] = 1;
                arr[currentIndex] = 0;
            }
            else
            {
                Console.WriteLine("Cannot move upward...!!");
            }

        
        }

        static void LeftShift4()
        {
            currentIndex = indexOf1();
            if ((currentIndex % orderOfMatrix) != 0)
            {
                arr[currentIndex - 1] = 1;
                arr[currentIndex] = 0;
            }
            else
            {
                Console.WriteLine("Cannot move to Left side...!!");
            }
        }

        static void RightShift6()
        {
            currentIndex = indexOf1();
            if ((currentIndex % orderOfMatrix) != orderOfMatrix - 1)
            {
                arr[currentIndex + 1] = 1;
                arr[currentIndex] = 0;
            }
            else
            {
                Console.WriteLine("Cannot move Right...!!");
            }
        }

        static void DownShift8()
        {
            currentIndex = indexOf1();
            if ((currentIndex / orderOfMatrix) != orderOfMatrix - 1)
            {
                arr[currentIndex + orderOfMatrix] = 1;
                arr[currentIndex] = 0;
            }
            else
            {
                Console.WriteLine("Cannot move Downshift...!!");
            }

        }


        //*****************   3    ***********************
        void ShiftsOP()
        {
            int userchoice = 0;
            while (userchoice != 1)
            {
                Display();
                Console.Write("\nEnter the operation to perform(1.Exit): ");
                userchoice = int.Parse(Console.ReadLine());

                switch (userchoice)
                {
                    case 1:
                        Console.WriteLine("Quting...\n");
                        break;
                    case 2:
                        upShift2();
                       
                        break;
                    case 4:
                        LeftShift4();
                       
                        break;
                    case 6:
                        RightShift6();
                       
                        break;
                    case 8:
                        DownShift8();
                      
                        break;
                    default:
                        Console.WriteLine("Please choose a valid key to shift...\n");
                        break;
                }
            }
        }



        //*****************   6    ***********************
        static int indexOf1()
        {
            for (int i = 0; i < (orderOfMatrix * orderOfMatrix); i++)
            {
                if (arr[i] == 1)
                    return i;
            }
            return 0;
        }


        //*****************   2    ***********************
        void readInput()
        {
            Console.Write("Enter order of matrix: ");
            orderOfMatrix = int.Parse(Console.ReadLine());
            arr = new int[orderOfMatrix * orderOfMatrix];
            arr[orderOfMatrix * orderOfMatrix - orderOfMatrix] = 1;
        }

        //*****************   4    ***********************
        void Display()
        {
            for (int i = 0; i < (orderOfMatrix * orderOfMatrix); i++)
            {
                if (i % orderOfMatrix == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(arr[i] + " ");
            }
        }

        //*****************   1    ***********************
        static void Main()
        {
            puzzle t1 = new puzzle();
            t1.readInput();
            t1.ShiftsOP();

        }
    }

}
