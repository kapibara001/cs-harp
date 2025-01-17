using System;

namespace arrayOfPointers19 {
    class Program {
        static void Main() {
            /*
            Robot Max = new Robot("Killer", "Maxim", 124, 125);
            Max.inputInfoAboutRobot();
            Max.printInfoAboutRobot();
            */

            Killer killer = new Killer("Killer", "Maxim", 90, 80, 75);
            //killer.inputInfoAboutRobot();
            killer.printInfoAboutRobot();
            string spec = killer.specials();
            Console.Write(spec);
        }
    }
}