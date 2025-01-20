using System;

namespace VirtualMethods20 {
    class Car {
        private string? type;
        private uint price;
        private short weight, lenght;

        public Car() {}
        public Car(string type, uint price, short weight, short lenght) {
            this.setCarValue(type, price, weight, lenght);
            //this.printCarValues();
        }
        public void setCarValue(string type, uint price, short weight, short lenght) {
            this.type = type;
            this.price = price;
            this.weight = weight;
            this.lenght = lenght;
        }
        public virtual void printCarValues() { // Делаем данный метод виртаульным при помощи ключевого слова virtual
        // А если метод virtual, это значит мы можем переписать его в классе-наследнике
            Console.Write($"\nObject initialized. \n{type} Car ${price} Weight: {weight}lb Lenght: {lenght}cm ");
        }
    }
}