using System;
namespace code {
    class Switchcase {
        static void Main() {
            Console.Write("Укажите какое-то число: ");
            short num = Convert.ToInt16(Console.ReadLine());

        // Switch() {case n: ... break; case m: ... break;}
            switch(num) {
                case 2:
                    Console.WriteLine("Мало");
                    break;
                case 3:
                case 15:
                case 23:
                    Console.WriteLine("Понял!");
                    break;
                default:
                    Console.WriteLine("Число не распознано!");
                    break;
            }
        }
    }
}