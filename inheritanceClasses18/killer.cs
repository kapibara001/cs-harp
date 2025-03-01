using System;

namespace inheritanceClasses18 {
    class Killer : Robot { // Наследование родительского класса Robot классом Killer. 
                           // В нем уже содержаться конструкции, которые содержаться в классе Robot, но КОНСТРУКТОРЫ НЕ НАСЛЕДУЮТСЯ. Их надо переписывать
    /* 
    Наследование классов нужно для того, чтобы на общий скелет накидывать разные параметры в разных классах. 
    То есть допустим есть просто класс робот, в котором указаны только его материал(сталь и наличие глаз, например).
    И на этот скелет мы пишем класс наследник, в котором указываем имя робота "Максим", а другому даем имя "ЛОИФ". И так с любями полями 
    */
        private byte speed;

        public void Lazer() {
            Console.WriteLine("TSHHHHHH - Lazer Killer");
            this.surName = "Killerovich"; // Редактирование поля с мод. доступа protected
        }

        public Killer() {}
        public Killer(string name, short weight, byte[] coordinates, byte health, byte speed) : base(name, weight, coordinates, health) {
            // Через " : base " мы передали эти параметры в класс родитель, где они подставятся в значения его конструктора c подходящими параметрами
            this.speed = speed; // Дополнили данные конструктора родителя конструктором класса-наследника
            
            base.addParametrsInRobotsInfo($"Speed: {speed}");
            base.PrintInfoAboutRobot(); // Если нам надо вызвать какой-метод в классе наследнике из класса родителя, можно тоже использовать ключевое слово base 
        }
    


    }
}
