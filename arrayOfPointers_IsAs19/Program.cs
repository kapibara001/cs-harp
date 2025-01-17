using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace arrayOfPointers_IsAs19 {
    class Program {
        static void Main() {
            /*
            Robot Max = new Robot("Killer", "Maxim", 124, 125);
            Max.inputInfoAboutRobot();
            Max.printInfoAboutRobot();
            

            Killer killer = new Killer("Maxim", 125, 90, 125);
            //killer.inputInfoAboutRobot();
            killer.printInfoAboutRobot();
            string spec = killer.specials();
            Console.Write(spec);
            */

            List<Killer> killers = new List<Killer> ();
            killers.Add(new Killer("Nikita", 170, 70, 200));
            killers.Add(new Killer("Eva", 270, 170, 250));
            killers.Add(new Killer("Console", 270, 30, 100));
            killers.Add(new Killer("Mita", 150, 10, 233));

            Robot newRobot = null;

            foreach (Killer obj in killers) { // Перебор массива с объектами на основе какого-либо класса
                if (obj.Name == "Nikita") {
            // AS - оператор, позволящий один определенный объект с одним определенным типом данных с определенным классом к объекту другого типа данных
                    newRobot = obj as Robot; // Определенный объект "приводим" к другому классу, то есть этот(в условии) 
                                             // объект был на основе класса Killer, а мы заставили его быть объектом на основе класса Robot
                    //newRobot.specials(); // Не можем обратиться к этому методу(он в killerRobot) т.к. теперь мы рассматриваем этот объект на основе класса Robot, где этого метода нет
                    Console.WriteLine(obj.Name);
                    //Console.WriteLine(obj.specials()); // Однако мы можем обращаться к нему тут т.к не было замены 
                
            // IS - оператор, позволяющий проверить преверженность объекта к определенному типу данных, классу:
                    Console.WriteLine(obj is Robot); // объекты созданы на основе класса Robot, поэтому вывведет True
                    Console.WriteLine(obj is Program); // Выведет false т.к объекты никак не касаются Program. Введет false 
                }
            }
        }
    }
}