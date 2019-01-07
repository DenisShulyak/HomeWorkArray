using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) ");
            ConsoleKeyInfo Symbol;
            int countTuchSpace = 0;
            do
            {
                Console.WriteLine("Введите символ(Нажмите точку, если хотите закончить и подсчитать кол-во пробелов): ");
                Symbol = Console.ReadKey();
                Console.WriteLine();
                if (Symbol.KeyChar == ' ')
                {
                    countTuchSpace++;
                }
                if (Symbol.KeyChar == '.')
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Кол-во введенных пробелов пользователем: " + countTuchSpace);
            Console.WriteLine();

            Console.WriteLine("2) ");
           
            int LengthTicketNumber = 6;

            int[] ticketNumbers = new int[LengthTicketNumber];
            int sum1 = 0;//Сумма первых трех чисел
            int sum2 = 0;//Сумма последних трех чисел
            for(int i = 0; i < ticketNumbers.Length;i++)
            {
                Console.WriteLine("Введите {0}-ю цифру билета", i + 1);
                ticketNumbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ваш номер билета: " + ticketNumbers[0] + ticketNumbers[1] + ticketNumbers[2] + ticketNumbers[3] + ticketNumbers[4] + ticketNumbers[5]);
for(int i =0; i < ticketNumbers.Length/2;i++)
            {
                sum1 += ticketNumbers[i];
            }
for(int i = ticketNumbers.Length/2;i < ticketNumbers.Length;i++)
            {
                sum2 += ticketNumbers[i];
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Ваш билет счастливый!");
            }
            else
            {
                Console.WriteLine("Ваш билет не счастливый");

            }

            Console.WriteLine();

            Console.WriteLine("3) ");


          
            ConsoleKeyInfo symbol;
            do
            {
                Console.WriteLine("Введите символ для конвертации регистра(Для завершения нажмите пробел): ");
                symbol = Console.ReadKey();
                Console.WriteLine("Введенный символ: " + symbol.KeyChar);
                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                {
                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                        Console.WriteLine("Конвертируемый символ: " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                    else
                    {
                        Console.WriteLine("Конвертируемый символ: " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
                }
                if (Convert.ToInt32(symbol.KeyChar) == ' ')
                {
                    break;
                }
            } while (true);
            Console.WriteLine();

            Console.WriteLine("4) ");
            int number1;
            int number2;
            Console.WriteLine("Введите первое число: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число(больше первого): ");
            number2 = int.Parse(Console.ReadLine());
            int Length = number2 - number1 + 1;
            int[] numericSpace = new int[Length];
            if (number1<number2)
            {
                for(int i = 0;i < numericSpace.Length;i++)
                {
                    numericSpace[i] = number1 + i;
                }
                Console.WriteLine("Результат: ");
                for(int i = 0; i < numericSpace.Length;i++)
                {
                    for (int j = 0; j < numericSpace[i]; j++)
                    {
                        Console.Write(numericSpace[i]);
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Первое число не меньше второго!: ");
            }
            Console.WriteLine();

            Console.WriteLine("5) ");
            int number;
            Console.WriteLine("Введите целое число > 0: ");
            number = int.Parse(Console.ReadLine());
            int[] numbers = number.ToString().ToCharArray().Select(x => x - '0').ToArray();
            Array.Reverse(numbers);
            Console.WriteLine("Данное число: "+number);
            Console.WriteLine("Число читая справа налево: ");

            for (int  i = 0;i < numbers.Length;i++)
            {
                Console.Write(numbers[i]);
            }
            Console.ReadLine();

        }
    }
}
