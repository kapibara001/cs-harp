using System;

namespace classes14 { // Чтобы Robot вообще было видно, нужно или пространство имен назвать как файл(общий), где я работаю
                      // Либо сверху прописать using файл(общий), где работаем
    class Program {
        static void Main() {
        /*// Если бы поля внутри класса Robot были public, работало бы так, но так не принято делать
            Robot runner = new Robot(); // Создание объекта на основе класса Robot 
            runner.name = "Player"; // Задание параметров объекта Robot, которые я ему написал в файле Robot.cs 
            runner.weight = 800; // Можно представить, что это обычные переменные и работать с ними точно также 
            runner.coordinates = new byte[]{0, 0, 0};
            Console.WriteLine(runner.name + "'s weight: " + runner.weight);

            Robot killer = new Robot(); // Создание совершенно другого объекта(не runner) на основе класса Robot
            killer.name = "Killer";
            killer.weight = 10000;
            killer.coordinates = new byte[] {100, 0, 100};
            Console.WriteLine($"{killer.name}'s weight is: {killer.weight}");
        */

            Robot runner = new Robot();
            runner.setValues("Runner", 800, new byte[] {0, 0, 0});
            runner.printValues();

            Robot killer = new Robot();
            killer.setValues("Killer", 10000, new byte[] {100, 100, 100});
            killer.printValues();
        }
    }
}