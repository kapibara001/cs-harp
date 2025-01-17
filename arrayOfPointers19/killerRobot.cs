using System;

namespace arrayOfPointers19 {
    class Killer : Robot {
        private byte HP;
        private string? specialsText;

        public Killer() {}
        public Killer(string typeRobot, string name, uint weight, byte speed, byte HP) : base(typeRobot, name, weight, speed) {
            this.HP = HP;
            base.addInfoAboutRobot($"HP: {HP}");
        }

        public string specials() {
            specialsText += "Смертельный лазер, полет";
            return "Specials: " + specialsText + "\n";
        }
    }
}