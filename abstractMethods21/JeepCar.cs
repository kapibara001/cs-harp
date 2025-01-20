using System;

namespace VirtualMethods20 {
    class Jeep : Car {
        private float width;

        public Jeep() {}
        public Jeep(string type, uint price, short weight, short lenght, float width) : base(type, price, weight, lenght) {
            this.width = width;
        }

        public override void printCarValues() { 
            base.printCarValues();

            Console.Write($"Width: {this.width}m");
        } 
    }
}