using System;

namespace inheritanceClasses18 {
    class Robot {
        private string name;
        private short weight;
        private byte[] coordinates;
        private byte health;
        private short speed;

        private string allinfoaboutrobot = "";
    // protected - модификатор доступа, при котором поле доступно в самом классе, где поле или метод создано и в классах наследниках


        public Robot() {}
        public Robot(string name, short weight, byte[] coordinates, byte health) {
            Console.WriteLine("\nObject has been created");
            setValues(name, weight, coordinates, health);
        }

        public void setValues(string name, short weight, byte[] coordinates, byte health) {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
            this.health = health;
            
            allinfoaboutrobot += $"Name: {name}\n";
            allinfoaboutrobot += $"Weight: {weight}\n";
            allinfoaboutrobot += $"Health: {health}\n";
            allinfoaboutrobot += $"Coordinates: ";
            foreach (byte coordinate in coordinates) {
                allinfoaboutrobot += $"{coordinate} ";
            }
            allinfoaboutrobot += "\n";
        }
        public void addParametrsInRobotsInfo(string text) {
            allinfoaboutrobot += text + "\n";
        }

        public void PrintInfoAboutRobot() {
            Console.Write(allinfoaboutrobot);
        }

    }
}
