using System;

namespace get_set17 {
    class Robot { 
    // За счет аксессоров мы можем контролировать процесс установки, а также получния данных из каких-либо полей.
    // Аксессор можно применить к определнному полю(name, weight ... ). Можем в аксессоре указать, что будет происходить при получении данных из поля, и 
    // что будет происходить при установке данных в поле 
        static int count = 0;

        private string name;
        private int weight;
        private byte[] coordinates;

        public Robot(string name, byte[] coordinates) { 
            this.name = name;
            this.coordinates = coordinates; 
            
            Console.WriteLine($"Данные для объекта {name} заданы.");
            count++;
        }

        public int Weight {// Указание аксессора(название поля с заглавной буквы). Можно указывать любой модификатор доступа(по ситуации).
            get { // Сработает при попытке получения данных из этого поля. 
                Console.Write("Результат: ");
                return this.weight; // Можно обращаться к любым полям того же типа данных
            } 
            set { // Сработает при попытке установить внутрь этого аксессора
                if (value < 1) // Проверка на то, что пытается передать пользователь в переменную. Если менее 1 - вес ставится 1, иначе в поле ставится то, что передал пользователь
                    this.weight = 1; 
                else if (value >= 5000) {
                    this.weight = 5000;
                }
                else {
                    this.weight = value;
                }
            }
        } 

        public int Width { private get; set; } // Задание акссесора в таком виде нужно для того, чтобы ограничить доступ акссесоров пользователю
        // по умолчанию (Width { get; set; }) get и set идут с мод. доступа public. Но можно и изменить мод.(пример): Width { private get; static set; }
        
        public void PrintValues() {
            Console.Write($"name: {name}\nweight: {weight}\ncoordinates: ");
            foreach (byte el in coordinates) {
                Console.Write(el + " ");
            }
            Console.Write("\n\n");
        }
        public static void printCount() {
            Console.WriteLine($"Создано {count} объектов на основе класса Robot.");
        }

    }
}