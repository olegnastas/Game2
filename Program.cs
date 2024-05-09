using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higer;
            int triesCount = 5;
            int userInput;
            Random random = new Random();

            number = random.Next(1,50);
            lower = random.Next(number -1,number);
            higer = random.Next(number +1,number +10);

            Console.WriteLine($"Мы загадали число от 0 до 100, которое больше чем{lower},но меньше чем {higer}");
            Console.WriteLine($"Что это за число? У нас {triesCount} попыток отгадать");

            while( triesCount-- > 0 ) 
            {
                Console.Write("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("вы правы это было число: " +number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно попробуйте еще раз");
                    Console.WriteLine("Вас ждет успех!");
                }

                
            }

            if (triesCount <0)
            {
                Console.WriteLine("Вы проиграли! Это было число " + number + ".");
                Console.WriteLine($"{userInput}");
            }
            
        }
    }
}
