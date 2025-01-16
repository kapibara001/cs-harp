using System;

namespace inheritanceClasses18 {
    class Program {
    // Класс наследик - класс, который полностью наследует все поля, асессоры, конструкторы, методы и тп родительского класса
        static void Main() {
            Robot Maxim = new Robot("Maxim", 72, new byte[] {1, 2, 3}, 255);
            Maxim.PrintInfoAboutRobot();

            Killer killer = new Killer("Matv", 83, new byte[] {0, 0, 0}, 250, 80); // Использование класса наследника 
            // Matvey.Health = 15;  // Этот аксессор мы добавили только в классе Killer. 
                                    // То есть он будет доступен в объектах класса Killer, а в объектах класса Robot и его других наследниках - нет.
            killer.Lazer();
            //Matvey.PrintInfoAboutRobot();

            Hiller hiller = new Hiller("Nikita", 45, new byte[] {10, 2, 2}, 75, 100);
            hiller.hillProcess();
            
        }
    }
}