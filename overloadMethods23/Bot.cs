using System;

namespace interface22 {
    class Bot : Car, IRun { 
        public Bot() {}
        public Bot(string type, uint price, short weight, short lenght) : base(type, price, weight, lenght) {
            
        }

        public override void printCarValues() {
            Console.WriteLine($"\nType: {this.Type}\nPrice: ${this.Price}\nWeight/Height: {this.Weight}/{this.Lenght}");
        }
    }
}