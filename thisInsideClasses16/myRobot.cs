using System;

namespace thisInsideClasses16 {
    class Robot { 
        private string name;
        private int weight;
        private byte[] coordinates;

        public Robot(string name, int weight, byte[] coordinates) { 
            this.name = name; // Если убрать отличительные знаки(как правило указывают одинаковые названия полей здесь), то будет вызываться ошибка, тут и приходит на помощь ключевое слово this 
            this.weight = weight; // this.поле - this в данном случае указывает на поля, принадлежащие нашему классу, то есть поля в 5, 6, 7 строках, а то что после "=", это параметры конструктора
            this.coordinates = coordinates; // this НЕЛЬЗЯ ПРИМЕНЯТЬ К STATIC модификаторам т.к статик принадлежат к классу в целом, а не к объектам
            
            Console.WriteLine($"Данные для объекта {name} заданы.");
            this.PrintValues(); // Обычно это делают(добавляют this.), чтобы явно указать то, откуда этот метод берется, просто уточняет то, что метод принадлежит только этому классу и никакому другому
        }
        
        public void PrintValues() {
            Console.Write($"name: {name},\nweight: {weight},\ncoordinates: ");
            foreach (byte el in coordinates) {
                Console.Write(el + " ");
            }
        }

    }
}