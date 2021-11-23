using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа: Калькулятор");
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;
            double result4 = 0;
            int result5 = 0;

            try
            {
                Console.Write("Введите целое число A = ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число B = ");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Введите код требуемой операции: ");
                Console.WriteLine("     1 - сложение");
                Console.WriteLine("     2 - вычитание");
                Console.WriteLine("     3 - произведение");
                Console.WriteLine("     4 - частное");
                Console.Write("Ваш выбор: ");
                int C = Convert.ToInt32(Console.ReadLine());
               
                if (C == 1)
                {
                    Console.WriteLine("Выбранная операция: сложение");
                    result1 = A + B;
                    Console.WriteLine();
                    Console.WriteLine("Результат: А + В = {0}", result1);
                }
                if (C == 2)
                {
                    Console.WriteLine("Выбранная операция: вычитание");
                    result2 = A - B;
                    Console.WriteLine();
                    Console.WriteLine("Результат: А - В = {0}", result2);
                }
                if (C == 3)
                {
                    Console.WriteLine("Выбранная операция: произведение");
                    result3 = A * B;
                    Console.WriteLine();
                    Console.WriteLine("Результат: А * В = {0}", result3);
                }
                if (C == 4 & B != 0)
                {
                    Console.WriteLine("Выбранная операция: частное");
                    result4 = (double) A / B;
                    Console.WriteLine();
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.WriteLine("Результат: А / В = {0}", Math.Round(result4, 2));
                }
                if (C == 4 & A == 0 & B == 0)
                {
                    Console.WriteLine("Выбранная операция: частное");
                    Console.WriteLine();
                    Console.WriteLine("Ошибка! Попытка деления ноль на ноль!");
                }
                if (C == 4 & B == 0 & A != 0)
                {
                    Console.WriteLine("Выбранная операция: частное");
                    result5 = A / B;
                    Console.WriteLine();
                    Console.WriteLine("Результат: А / В = {0}", result5);
                }
                else if (C != 1 & C != 2 & C != 3 & C != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Такого параметра не существует");
                }
                


            }
            
            // В случаях, когда результат вещественное число, при попытке деления на 0 получаем знак ?
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine();
                Console.Write("Ошибка! ");
                Console.Write(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка! Введите целое число. ");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        
    }
    
}
