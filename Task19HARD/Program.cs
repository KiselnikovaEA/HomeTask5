using System;

namespace HomeTasks_KisEA
{
    class Program           // Программа проверяет палиндромность N - значного числа
    {
        static void Main (string[] args)
        {
            
            string Palindrom(int num)
            {
                if(num <= 0)
                {
                    return "Разрешается вводить только положительные целые числа";
                }
                else
                {
                    string str = num.ToString();
                    int flag = 0;
                    int[] array = new int[str.Length];

                    for (int i = 0; i < str.Length; i++){
                                                            array[i] = int.Parse(str[i].ToString());
                                                        }
                    for (int i = 0; i < array.Length/2; i ++){
                                                            if (array[i] == array[array.Length - i - 1]) i++;
                                                            else {
                                                                     flag = 1;
                                                                        break;
                                                                }
                                                            } 
                    if (flag == 1) return $"Число {num} не является палиндромом";
                    else return $"Число {num} является палиндромом";
                }

            }
            try{
                    Console.Write("Введите неотрицательное число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Palindrom(num));
                }
            catch{
                    Console.WriteLine("Вводить необходимо именно цифры");
                }   

        }

            


    }
}
