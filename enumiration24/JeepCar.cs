using System;
using System.ComponentModel;

namespace interface22 {

    enum Types { // Инициализация перечисления. Description необязательный компонент, он 
        [Description("Это Враг. Он зли")] // лишь помогает "вспомнить" что это за объект, добавляет описание 
        Enemy, 
        
        [Description("Это герой. Его не должно быть можно убить(бессмертный)")]
        Hero, 

        // [Description("Это предатель. Его цель - убить всю команду Enemy")]
        Traitor 
    } 
    

    class Jeep : Car, IJump {
        private float width;
        public Types types; // поле на основе перечисления Types с именем types

        public Jeep() {}
        public Jeep(string type, uint price, short weight, short lenght, float width, Types types) : base(type, price, weight, lenght) {
            this.width = width;
            this.types = types; // Передали в аргументах функции и здесь подставили значение
        }

        public override void printCarValues() { 
            //base.printCarValues();
            Console.WriteLine($"\nType: {this.Type}\nPrice: ${this.Price}\nWeight/Height: {this.Weight}/{this.Lenght}\nWidth: {this.width}");
            //base.Jumpa();   

            if (this.types == Types.Hero) { // Проверка на установленный ползователем тип машинки
                Console.WriteLine("Your car is Hero!"); 
            } else if (this.types == Types.Enemy) {
                Console.WriteLine($"Your car is angry!<3. Type: {Types.Enemy}");
            }
        } 

        public void Jumped() {
            Console.WriteLine("Your car has been jumped");
        }
        public void Hello() {
            Console.WriteLine($" - and car is your's!");
        }
    }
}   