using System;
using System.ComponentModel;

namespace name {
    class Program {
        static void Main() {
        /*
            try {
                short num = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Вы ввели число " + num);
            } catch (FormatException) {
                Console.WriteLine("Вы ввели не тот формат");
            }
        */  

        /*   
            try {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int res = a/b;
                Console.WriteLine(res);
            } catch (DivideByZeroException) {
                Console.WriteLine("На 0 делить запрещено!");
            } catch (FormatException) {
                Console.WriteLine("Неверный формат");
            } finally { // Этот блок кода "дополняет" блок try. Сработает в любоом случае, даже если произошел вход в catch()
                Console.WriteLine("Код сработал и дошел до блока finally");
            }
        */

        // Практическое задание
            Console.WriteLine("Программа для деления чисел A и B(\"q\" для выхода)");
            while (true) {
                try {
                    Console.Write("Введите число A: ");
                    string a = Console.ReadLine();
                    if (a.ToLower() == "q") {
                        Console.WriteLine("Спасибо за пользование!");
                        break;
                    }
                    float newa = float.Parse(a);

                    Console.Write("Введите число B: ");
                    string b = Console.ReadLine();
                    if (b.ToLower() == "q") {
                        Console.WriteLine("Спасибо за пользование!");
                        break;
                    }
                    float newb = float.Parse(b);
                    if (newb == 0.0f) {
                        Console.WriteLine("Деление на 0 запрещено правилами математики. Попробуйте снова.");
                        break;
                    }

                    float res = newa/newb;
                    Console.WriteLine($"Результат деления {newa} на {newb}: {res}. \"Q\" или \"q\" для отмены.");
                } 
                catch (FormatException) {
                    Console.WriteLine("Неверный формат. Попробуйте еще раз.");
                }
            }
        }
    }
}