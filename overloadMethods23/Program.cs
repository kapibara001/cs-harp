using System;

namespace interface22 {
    class Program {
    /* Перегрузка - просто создание методы с точно таким же именем, куда заходит другое количество аругментов, 
    например: есть метод goCar, куда надо передать имя машины и скорость, мы пишем 
    
    public void goCar(string name, uint maxSpeed);

    но вдруг получается так, что у нас не объявлено имя, но нам все равно надо как-то обработать информацию, в 
    таком случае выполняем ПЕРЕГРУЗКУ функции, куда передаем только максимальную скорость: 

    public void goCar(uint maxSpeed);

    */
        static void Main() {
            //Car Hundai = new Car("Hetchback", 20000, 1500, 3000); // Выдает ошибку т.к на основе абстрактоного класса нельзя создать объекты
            //Hundai.printCarValues();

            // Jeep RamTRX = new Jeep("Jeep", 45000, 4500, 5, 2.15f);
            // RamTRX.printCarValues();
            // RamTRX.Hello();
            // RamTRX.Jumpa(); 
            // RamTRX.Jumped();

            // Bot bot1 = new Bot("Grand", 400000, 1200, 1);
            // bot1.printCarValues();

            // Bot bot2 = new Bot("GTA", 1000, 1500, 2);
            // bot1.printCarValues();

            // Bot bot3 = new Bot("Hetchback", 20000, 1500, 3000);
            // bot1.printCarValues();  

            // Multyply(15.4f, 3.2f);
             
        }

        public static void Multyply(int a, int b) {
            int result = a*b;
            System.Console.WriteLine($"Result a*b: {result}");
        }
        public static void Multyply(float a, float b) {
            float result = a*b;
            System.Console.WriteLine($"Result a*b: {result}");
        }
        public static void Multyply(int a) {
            Console.WriteLine($"Only 1 argument: {a}");
        }
    }
}