using System;
using System.Reflection.Metadata.Ecma335;

namespace arrayOfPointers_IsAs19 {
    class Robot {
        private string? name;
        private uint? weight;
        private byte? speed;
        private string? allinfo = "";

        public string Name {
            get {
                return name;
            }
            private set {} // Сделали так, чтобы нельзя было 
        }

        public Robot() {} // Установка конструктора по умолчанию
        public Robot(string name) {

        }
        public Robot(string name, uint weight, byte speed) {
            setValues(name, weight, speed);
            inputInfoAboutRobot();
            Console.WriteLine($"!!!     Данные {name} заданы     !!!");
        }

        public void setValues(string name, uint weight, byte speed) {
            this.name = name;
            this.weight = weight;
            this.speed = speed;
        } 

        public void inputInfoAboutRobot() {
            allinfo += $"Name: {name}\n";
            allinfo += $"Weight: {weight}\n";
            allinfo += $"Speed: {speed}\n";
        }
        public void addInfoAboutRobot(string text) {
            allinfo += text + "\n";
        }
        public void printInfoAboutRobot() {
            Console.Write(allinfo);
        }
    }
}