using System;

namespace classes14 {
    class Robot { // Внутри класса переменные теперь это ПОЛЯ, а функции становятся МЕТОДАМИ
    /*public protected private // наиболее распространенные  
        public - данное поле доступно отовсюду
        protected - поле доступно исключительно внутри этого класса, а также в классах наследниках
        private - данное поле или метод и тп доступен исключительно внутри этого класса

        Поидее все поля должны быть private или protected, тогда доступ к этим полям защищен.
    */
        /*public string name; // Задание ПОЛЯ в классе. Если бы было private, мы бы не могли обращться к этим полям
                              // в нашем основном файле просто так, программа бы их просто не видела 
        public int weight;
        public byte[] coordinates;*/
        
        private string name;
        private int weight;
        private byte[] coordinates;

    // Чтобы обращаться к private полям, надо создавать отдельные методы(функции)
        public void setValues(string _name, int _weight, byte[] _coodrinates) {
            //name = name; // Вызывает ошибку т.к компелятор не понимает, что куда подставить надо
            name = _name;
            weight = _weight;
            coordinates = _coodrinates;
        }
        public void printValues() {
            Console.Write(name + " weight: " + weight + ".\nCoordinates: ");
            foreach(byte coordinate in coordinates) {
                Console.Write(coordinate + " ");
            }
            Console.Write("\n");
        }
    }
}