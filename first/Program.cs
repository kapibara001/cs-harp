using System;

namespace first {
    class Program {
        static void Main() {
            Console.WriteLine("Hello world!"); // Мы пишем данные в 1 строку(Line)
            Console.Write("Привет!");
            Console.Write("Привет!\n"); // Выведется Привет!Привет! так как нет переноса на новую строку. (\n для след примера, тип на сл строку перенос)
            Console.Write("Новаястрока!");

            Console.ReadKey(); // Ожидаем ввода хотя бы одного символа 
            Console.ReadLine(); // Вводим данные с клавиатуры до нажатия Enter
        }
    }
}
