using System;

namespace inheritanceClasses18 {
    class Program {
    // Класс наследик - класс, который полностью наследует все поля, асессоры, конструкторы, методы и тп родительского класса
        static void Main() {
            Robot Maxim = new Robot();
            Maxim.setValues("Maxim", 72, new byte[] {1, 2, 3});
            Maxim.PrintInfoAboutRobot();

            Killer Matvey = new Killer(); // Использование класса наследника 
            Matvey.setValues("Matv", 83, new byte[] {0, 0, 0});
            Matvey.Health = 15; // Этот аксессор мы добавили в классе Killer. 
                                // То есть он будет доступен в объектах класса Killer, а в объектах класса Robot и его других наследниках - нет.
            Matvey.Lazer();
            Matvey.PrintInfoAboutRobot();
            
        }
    }
}