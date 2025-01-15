using System;

namespace get_set17 {
    class Program {
        static void Main() {
        // Если нужно контролировать получение и установку данных в определенных полях, аксессоры являются лучшим решением
            Robot Maxim = new Robot("Max", new byte[] {1, 2, 1});
            Maxim.Weight = -100; // применение метода set(установка данных)
            Console.WriteLine(Maxim.Weight); // применение метода get(получение данных). Они по сути заменяют методы для получения и установки данных в поля
            Maxim.PrintValues();

            Maxim.Width = -100; // Не выдает ошибку т.к по умолчанию дается мод  доступа public
            Console.WriteLine(Maxim.Width); // Выдает ошибку так как мы параметру get(получения данных) метода Width(не weight) дали мод. доступа private

            Robot Egor = new Robot("Egr", new byte[] {10, 23, 11});
            Egor.Weight = 152;
            Egor.PrintValues();
        }
    }
}