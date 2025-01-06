using System;

namespace th5 {
    class main5 {
        static void Main() {
            int maxspeed = 270;
            bool isHasCar = true;

        // if - else if - else
        // && - and(логический и), || - or(логический или), 
            if (isHasCar) {
                if(maxspeed >= 250) {
                    Console.Write("У вас очень крутая машина) ");
                } else if (maxspeed < 250 && maxspeed >= 150) { 
                    Console.Write("Автомобиль достойный. ");
                } else if (maxspeed < 150 && maxspeed >= 90) {
                    Console.Write("Терпимая максималка. ");
                } else {
                    Console.Write("Как ты евздишь на этом вообще? ");
                } 
                Console.Write("Твоя максимальная скорость: {0}. ", maxspeed);
            } else {
                maxspeed = 0;
                Console.WriteLine("Купи уже себе тачку, чертила. Твоя максималка - {0}, лох! ", maxspeed);
            }
        }
    }
}