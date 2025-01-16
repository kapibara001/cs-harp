using System;

namespace inheritanceClasses18 {
    class Robot {
        static int count;
        private string name;
        private short weight;
        private byte[] coordinates;

        public void setValues(string name, short weight, byte[] coordinates) {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;

        }

        public void PrintInfoAboutRobot() {
            Console.Write($"Name: {name}\nWeight: {weight}\nCoordinates: ");
            foreach(byte coordinate in coordinates) {
                Console.Write(coordinate + " ");
            }
            Console.Write("\n\n");
        }
    }
}