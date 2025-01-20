using System;

namespace VirtualMethods20 {
    class Program {
        static void Main() {
            Car Hundai = new Car("Hetchback", 20000, 1500, 3000);
            Hundai.printCarValues();

            Jeep RamTRX = new Jeep("Jeep", 45000, 4500, 5, 2.15f);
            RamTRX.printCarValues();
        }
    }
}