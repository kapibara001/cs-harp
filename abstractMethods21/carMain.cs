using System;

namespace VirtualMethods20 {
    abstract class Car {
        private string type;
        private uint price;
        private short weight, lenght;

        public string Type {
            get {
                return this.type;
            }
            private set{} // запрещаем устанавливать значения
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
        abstract public void printCarValues(); /* Задание абстрактного метода. ОПЯТЬ ПАРА abstract - override(опять меняем метод)
        Если написать код внутри него - выдаст ошибку. Он тут и не нужен т.к мы им все равно воспользоваться 
        не можем просто потому что он абстрактный. То есть мы просто обозначили то, что он есть, а его 
        функционал в каждом классе наследнике будет прописан отдельно и будет "уникальным".
         */
    }
}