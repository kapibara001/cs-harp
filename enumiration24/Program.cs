using System;

namespace interface22 {
    class Program {
    /*
    enumiration(перечисления) - позволяют нам создать список, в котором у нас через запятую будут прописаны определенные значения.
    Далее мы можем создать некотрое поле на основе этого перечисления, и для этого поля мы можем установить некоторое значение, кототрое
    будет находиться внутри этого перечисления
    */
        static void Main() {
            //Car Hundai = new Car("Hetchback", 20000, 1500, 3000); // Выдает ошибку т.к на основе абстрактоного класса нельзя создать объекты
            //Hundai.printCarValues();

            Jeep RamTRX = new Jeep("Jeep", 45000, 4500, 5, 2.15f, Types.Enemy); // Указание типа автомобиля (Types.одинИзЭлементовПеречисления)
            RamTRX.printCarValues();
            RamTRX.Hello();
            RamTRX.Jumpa(); 
            RamTRX.Jumped();

            // Bot bot1 = new Bot("Grand", 400000, 1200, 1);
            // bot1.printCarValues();

            // Bot bot2 = new Bot("GTA", 1000, 1500, 2);
            // bot1.printCarValues();

            // Bot bot3 = new Bot("Hetchback", 20000, 1500, 3000);
            // bot1.printCarValues();  
             
        }
    }
}