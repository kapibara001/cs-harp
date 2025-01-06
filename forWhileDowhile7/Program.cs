using System;

namespace forwhile {
    class myclass {
        static void Main() {

        // Цикл for (начало; до когда; с каким шагом) {...}
            //for (byte i=0; i<=100; i++) {
            //    Console.WriteLine("Элемент {0}", i);
            //}

            //Console.WriteLine("\n");
            //for (short i=32766; i>10; i/=2) {
            //    Console.WriteLine("Стало {0}", i);
            //}

        // Цикл while() {}
        /*
            byte i = 10;
            while(i >= 1) {
                Console.WriteLine("Element: {0}", i);
                i--;
            }
        
            bool isEnd = true;
            while(isEnd) {
                Console.Write("Напишите что-то: ");
                string input = Console.ReadLine();
                if(input == "end") {
                    Console.WriteLine("\nОтлично пообщались! Удачного дня!");
                    isEnd = false;
                }
            }
        */


        // Цикл do {} while()
        /*
            short num = 1;
            do {
                Console.WriteLine("Element: {0}", num);
                num++;
            } while (num <= 10);
        */


        // Операторы циклов
            for (short i=-15; i<10; i++) {
                //if (i > 5) 
                //    break; // Выходим из for
                
                if (i%2 == 0) {
                    continue; // Просто пропуск элемента, который попадает под данные условия
                } else {
                    Console.WriteLine("El: " + i);
                }
            }
        }
    }
}