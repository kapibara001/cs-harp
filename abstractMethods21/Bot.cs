using System;

namespace VirtualMethods20 {
    class Bot : Car { 
        public Bot() {}
        public Bot(string type, uint price, short weight, short lenght) : base(type, price, weight, lenght) {
            
        }

        public override void printCarValues() {
            //Console.WriteLine($"{this.type}"); 
            /* Так как все мод. доступа в carMain(родитель) private, мы не 
            сможем просто так установить значения для полей. Тут надоделать аксессоры в классе родителе и так 
            уже устанавливать значения.*/
            Console.WriteLine($"\nType: {this.Type}\nPrice: ${this.Price}\nWeight/Height: {this.Weight}/{this.Lenght}");
        }
    }
}