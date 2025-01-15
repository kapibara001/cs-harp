using System;
using System.Security.Cryptography.X509Certificates;

namespace classes14 { // Чтобы Robot вообще было видно, нужно или пространство имен назвать как файл(общий), где я работаю
                      // Либо сверху прописать using файл(общий), где работаем
    class Program { 
        static void Main() {
        /* // Без конструкторов пришлось бы данные для объектов класса задавать так
            Robot runner = new Robot();
            runner.setValues("Runner", 800, new byte[] {0, 0, 0});
            runner.printValues();

            Robot killer = new Robot();
            killer.setValues("Killer", 10000, new byte[] {100, 100, 100});
            killer.printValues();
        */

        Robot Maxim = new Robot("Maxim", 72, new byte[]{0, 0, 0});
        Maxim.printValues();

        Robot Matvey = new Robot("Matvey"); // АВтоматическое применение варианта констркутора, в который нужно передать лишь 1 аргумент
        //Matvey.printValues();

        Robot.Print(); // Применение статического метода класса Robot

        }
    }
}