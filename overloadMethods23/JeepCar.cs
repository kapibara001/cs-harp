using System;

namespace interface22 {
    class Jeep : Car, IJump {
        private float width;

        public Jeep() {}
        public Jeep(string type, uint price, short weight, short lenght, float width) : base(type, price, weight, lenght) {
            this.width = width;
        }

        public override void printCarValues() { 
            //base.printCarValues();
            Console.WriteLine($"\nType: {this.Type}\nPrice: ${this.Price}\nWeight/Height: {this.Weight}/{this.Lenght}\nWidth: {this.width}");
            //base.Jumpa();   
        } 

        public void Jumped() {
            Console.WriteLine("Your car has been jumped");
        }
        public void Hello() {
            Console.WriteLine($" - and car is your's!");
        }
    }
}   