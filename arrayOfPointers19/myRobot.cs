using System;

namespace arrayOfPointers19 {
    class Robot {
        private string? typeRobot, name;
        private uint? weight;
        private byte? speed;
        private string? allinfo = "";


        public Robot() {} // Установка конструктора по умолчанию
        public Robot(string typeRobot, string name, uint weight, byte speed) {
            setValues(typeRobot, name, weight, speed);
            inputInfoAboutRobot();
            Console.WriteLine($"!!!     Данные {name} заданы     !!!");
        }

        public void setValues(string typeRobot, string name, uint weight, byte speed) {
            this.typeRobot = typeRobot;
            this.name = name;
            this.weight = weight;
            this.speed = speed;
        } 

        public void inputInfoAboutRobot() {
            allinfo += $"Robot type: {typeRobot}\n";
            allinfo += $"Name: {name}\n";
            allinfo += $"Weight: {weight}\n";
            allinfo += $"Speed: {speed}\n";
        }
        public void addInfoAboutRobot(string text) {
            allinfo += text;
        }
        public void printInfoAboutRobot() {
            Console.WriteLine(allinfo);
        }
    }
}