using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа вычисляет расстояние между двумя точками в N-мерном пространстве
    {
        static void Main (string[] args)
        {

            string SegmentLength()
            {

                Console.Write("Введите количество измерений в пространстве: ");
                int multidimension = Convert.ToInt32(Console.ReadLine());
                
                if (multidimension > 1)
                {

                    int[] a = new int[multidimension];
                    int[] b = new int[multidimension];

                    for (int i = 0; i < multidimension; i++){
                                                            Console.Write($"Введите координату {i+1}-ю координату 1-й точки: ");
                                                            a[i] = Convert.ToInt32(Console.ReadLine());
                                                            }

                    for (int i = 0; i < multidimension; i++){
                                                            Console.Write($"Введите координату {i+1}-ю координату 2-й точки: ");
                                                            b[i] = Convert.ToInt32(Console.ReadLine());
                                                            }
                
                    double d = 0;
                    for (int i = 0; i < multidimension; i++){
                                                            d = d + (int)Math.Pow(b[i] - a[i], 2);
                                                            }
                
                    d = Math.Sqrt(d);
                    return $"Расстояние между двумя точками в {multidimension}-мерном пространстве равно {d}";

                }
                else
                {
                    return $"{multidimension}-мерного пространства не существует. Введите число больше 1";
                }
             
            }

            try
            {
                Console.WriteLine(SegmentLength());
            }  
            catch
            {
                Console.WriteLine("Вводить можно только целые числа и именно цифрами");
            }          
               
        }
    }
}
