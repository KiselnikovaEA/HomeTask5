using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа показывает разницу между максимальным и минимальным элементом
    {                   // в массиве вещественных чисел
        static void Main (string[] args)
        {
            double[] createNewArray(int size)
            {
                double[] array = new double[size];

                for (int i = 0; i < size; i++)
                {
                    array[i] = new Random().Next(100, 1000);
                }
                return array;
            }

            void printArray(double[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

            double findMaxElement(double[] array)
            {
                int i = 0;
                double maxElement = array[i];
                for(i = 1; i < array.Length; i++)
                {
                    if(array[i] > maxElement) maxElement = array[i];
                }
                return maxElement;
            }

            double findMinElement(double[] array)
            {
                int i = 0;
                double minElement = array[i];
                for(i = 1; i < array.Length; i++)
                {
                    if(array[i] < minElement) minElement = array[i];
                }
                return minElement;
            }

            Console.Write("Введите размерность массива: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            double[] numbers = createNewArray(arraySize);
            printArray(numbers);
            Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {findMaxElement(numbers) - findMinElement(numbers)}");
           
        }
    }
}