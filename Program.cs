using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        int[,] a = new int[10, 10];

        public void generateArray()
        {
            Random r = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    a[i, j] = r.Next(1, 15);
                }
            }
        }

        public void printArray()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }

        public void bubbleSortUp()
        {
            //int m = a.GetLength(0);
            //int n = a.GetLength(0);
            int m = 10;
            int n = 10;
            for (int i = 0; i<m; i++)
            {
                for (int j = 0; j<n-1; j++)
                {
                    if (a[i, j] > a[i, j + 1])
                    {
                       int temp = a[i, j];
                        a[i, j] = a[i, j + 1];
                        a[i, j + 1] = temp;
                    }
                }
            }   
        }


        static void bubbleSortSTR(int k, int[,] a)
        {
            //int m = a.GetLength(0);
            //int n = a.GetLength(0);
            int m = 10;
            int n = 10;
            //int k = Stro;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[k, j] > a[k, j + 1])
                    {
                        int temp = a[k, j];
                        a[k, j] = a[k, j + 1];
                        a[k, j + 1] = temp;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Программа пузырьковой сортировки");
            Console.WriteLine();
            Program Sort = new Program();
            Sort.generateArray();
            Console.WriteLine("Исходный массив:");
            Sort.printArray();
            Console.WriteLine();
            Sort.bubbleSortUp();
            Console.WriteLine("Массив после сортировки:");
            Sort.printArray();
            Console.WriteLine();
            int Stro = Convert.ToInt32(Console.ReadLine());
            Sort.bubbleSortSTR(Stro,a[10,10]);
            Console.WriteLine("Массив после сортировки по строке:");
            Sort.printArray();
            Console.ReadLine();
        }
    }
}
