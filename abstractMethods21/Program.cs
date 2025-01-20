using System;

namespace VirtualMethods20 {
    class Program {
        static void Main() {
        /*
        Абстрактные классы - это классы, на основе которых нельзя создать никакого объекта. Внутри таких классов мы 
        просто описываем определенные методы. Обычно они создаются для описания какого-либо общего
        объекта, действия, и дальше на основе этого абстрактного класса мы создаем можнество классов наследников,
        которые получат этот общий функционал из абстрактного класса.
        */
        
            //Car Hundai = new Car("Hetchback", 20000, 1500, 3000); // Выдает ошибку т.к на основе абстрактоного класса нельзя создать объекты
            //Hundai.printCarValues();

            Jeep RamTRX = new Jeep("Jeep", 45000, 4500, 5, 2.15f);
            RamTRX.printCarValues();

            Bot bot1 = new Bot("Grand", 400000, 1200, 1);
            bot1.printCarValues();

            Bot bot2 = new Bot("GTA", 1000, 1500, 2);
            bot1.printCarValues();

            Bot bot3 = new Bot("Hetchback", 20000, 1500, 3000);
            bot1.printCarValues();            
        }
    }
}