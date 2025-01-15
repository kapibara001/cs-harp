using System;

namespace classes14 {
    class Robot { 
    // модификатор доступа static говорит о том, метод или поле будет принадлежать к классу в целом, а не объектам
        public static int count=0; // к этому полю можно обратиться как Robot.count ... . Пример таких полей: Math.что-то. Это самое что-то и есть static поля
        // Также static переменные сохраняют свои значения, то есть с помощью них тут же можно создать метод подсчета созданных нами роботов
        private string name;
        private int weight;
        private byte[] coordinates;

    /* Констркутор - метод, который инициализируется с созданием объекта на основе класса, просто изначально он невидимый.
    Нужен он для упрощения задания полей объекта класса */
    // Если бы не конструктор, эта ф-я для задания данных была бы почти обязательна.
        /*public void setValues(string _name, int _weight, byte[] _coodrinates) {
            name = name; // Вызывает ошибку т.к компелятор не понимает, что куда подставить надо
            name = _name;
            weight = _weight;
            coordinates = _coodrinates;
        }*/

    // Момент задания конструктора 
        public Robot(string _name, int _weight, byte[] _coodrinates) { 
            name = _name;
            weight = _weight;
            coordinates = _coodrinates;
            Console.WriteLine($"Данные для объекта {name} заданы.");
            count++;
        }

        public Robot(string name) { // Задание констркутора класса Robot в том случае, если не будут переданы вообще никакие параметры. "Перегружать" конструктор класса можно сколь угодно много раз 
            Console.WriteLine($"Данные для объекта {name} НЕ переданы.");
            count++;
        } 

        public void printValues() {
            Console.Write(name + "'s weight: " + weight + ".\nCoordinates: ");
            foreach(byte coordinate in coordinates) {
                Console.Write(coordinate + " ");
            }
            Console.Write("\n");
        }

        public static void Print() {
            Console.WriteLine($"Объектов классa Robot создано: {count}");
        }

    }
}