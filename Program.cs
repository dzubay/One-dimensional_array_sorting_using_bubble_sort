using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_одномерного_масива_с_помощью_пузырьковой_сортировки
{

        internal class Program
    {
        static void Main()
        {
            // Определяем размер массива
            int size = 10;
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101); // Генерируем числа от 1-100
            }
            Console.WriteLine("Не отсортированный массив:");
            PrintArray(array);
            Console.ReadKey();

            // Сортировка массива по возрастанию
            BubbleSort(array);

            Console.WriteLine("Отсортированный массив:");
            PrintArray(array);
            Console.ReadKey();
        }

        // пузырьковая сортировка
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // для вывода массива
        static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
         Console.WriteLine();
        }
    }
}

