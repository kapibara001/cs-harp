using System;

namespace th4 {
    class myfile {
        static void Main() {
            Console.Write("Введите нецелое число через запятую(,): ");

            //user_input = Convert.ToDouble(Console.ReadLine()); // Чтобы исправить ошибку в этой строке, можно просто float в предыдущей поменять на double
            float user_input = float.Parse(Console.ReadLine()); // Второй способ исправления ошибки без перевода в double, только в консоли надо
                                                                // использовать НЕ ТОЧКУ, а ЗАПЯТУЮ
            float result = user_input + 10.1f; // Можно и без f, но как-то логичнее выглядит
            result = user_input - 10.1f;
            //result = user_input * 12.12f;
            //result = user_input / 1255.12f;
            //result = user_input % 10.2f;

            int a = 5, b = 6;
            int res = a + b;
            res += 12;





            Console.WriteLine("Переменная: " + result);
        }
    }
}