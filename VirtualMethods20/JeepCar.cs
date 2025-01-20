using System;

namespace VirtualMethods20 {
    class Jeep : Car {
        private float width;

        public Jeep() {}
        public Jeep(string type, uint price, short weight, short lenght, float width) : base(type, price, weight, lenght) {
            this.width = width;
        }

        public override void printCarValues() { // override - слово пара к virtual. Говорит о том, что этот метод является переписанным
            base.printCarValues();

            Console.Write($"Width: {this.width}m"); /* Дополнение к основному классу printCarValues(), 
            которое будет выводиться при вызове printCarValues() в основном файле, т.к теперь 
            вместо того метода вызывается переписанный нами(этот) */
        } 
    }
}