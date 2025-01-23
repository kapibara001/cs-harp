using System;

namespace interface22 {
    abstract class Car : IRun{ 
        private string type;
        private uint price;
        private short weight, lenght;
        private int mass;

        public string Type {
            get {
                return this.type;
            }
            private set{}
        }
        public uint Price {
            get {
                return this.price;
            }
            private set{}
        }
        public short Weight {
            get {
                return this.weight;
            }
            private set{}
        }
        public short Lenght {
            get {
                return this.lenght;
            }
            private set{}
        }

        // public int Mass {
        //     get { return this.mass; }
        //     set {
        //         if (value <= 0) {
        //             this.mass = 1300;
        //         } else if (value >= 30000) {
        //             this.mass = 3000;
        //         } else {
        //             this.mass = value;
        //         }
        //     }
        // }

        public float y { get; set; }


        public Car() {} 
        public Car(string type, uint price, short weight, short lenght) { // Перегрузка метода Car() из 38 строки
            this.setCarValue(type, price, weight, lenght);
            //this.printCarValues();
        }
        public void setCarValue(string type, uint price, short weight, short lenght) {
            this.type = type;
            this.price = price;
            this.weight = weight;
            this.lenght = lenght;
        }
        abstract public void printCarValues();

        public void CarMaxSpeed() {
            Console.WriteLine("MaxSpeed is HIGH!");
        }

        public void Jumpa() {
            Console.WriteLine("WOW! But how did you do that??? Cars cant jump!?");
        }
        public void Sweem() {
            Console.WriteLine("Tvoya popochka tak visbujdaet");
        }

    }
}