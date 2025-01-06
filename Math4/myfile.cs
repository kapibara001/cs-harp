using System;
using System.Formats.Asn1;

namespace th4 {
    class myfile {
        static void Main() {

        // Примеры мат. операций в C#
            //Console.Write("Введите нецелое число через запятую(,): ");

            //user_input = Convert.ToDouble(Console.ReadLine()); // Чтобы исправить ошибку в этой строке, можно просто float в предыдущей поменять на double
            //float user_input = float.Parse(Console.ReadLine()); // Второй способ исправления ошибки без перевода в double, только в консоли надо
                                                                // использовать НЕ ТОЧКУ, а ЗАПЯТУЮ
            //float result = user_input + 10.1f; // Можно и без f, но как-то логичнее выглядит
            //result = user_input - 10.1f;
            //result = user_input * 12.12f;
            //result = user_input / 1255.12f;
            //result = user_input % 10.2f;

            //result += 5.9f;
            //result -= 3.3f;
            //result /= 22.23f;
            //result *= 23.9f;

            //result++;
            //result--;



        // Встроенные различные функции (Math.функция)
            System.Console.WriteLine(); // cw - просто пишешь в коде, жмак TAB и все пояится на экране
            Console.WriteLine("Число ПИ: " + Math.PI); // вывод числа пи
            const short YEAR = 2025; // Задание константы
            Console.WriteLine("Число е: " + Math.E + "\n"); // Вывод математического числа е

            Console.WriteLine("4.5(Ceiling): " + Math.Ceiling(4.5f)); // Math.Ceiling - Округление в большую сторону
            Console.WriteLine("4.99(Floor): " + Math.Floor(4.99f)); // Math.Floor - округление в меньшую сторону
            Console.WriteLine("4.5(Cound): " + Math.Round(4.5f) + "\n"); // Округление по правилам матиматики

            Console.WriteLine("Максимум из 4, 5(max): " + Math.Max(4,5));
            Console.WriteLine("Минимум из 4, 5(max): " + Math.Min(4,5) + "\n");

            Console.WriteLine("Возведение в степень(.Pow(число, степень)): " + Math.Pow(5,2));
        
        // Практический пример
            Console.Write("Введите радиус шара: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            // Новый для нас вид вывода информации, некий аналог f'' строк в Python
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}.", radius, area); 
        }

        
    }
}