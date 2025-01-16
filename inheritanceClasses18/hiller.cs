using System;

namespace inheritanceClasses18 {
    class Hiller : Robot {
        private short speed;

        public Hiller() {}
        public Hiller(string name, short weight, byte[] coordinates, byte health, short speed) : base(name, weight, coordinates, health) {
            this.speed = speed;
            base.addParametrsInRobotsInfo($"Speed: {speed}");
            base.PrintInfoAboutRobot();
        }

        public void hillProcess() {
            Console.WriteLine("Object has been hilled!");
        }
    }
}