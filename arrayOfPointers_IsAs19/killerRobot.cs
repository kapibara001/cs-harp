using System;
using System.Reflection.Metadata.Ecma335;

namespace arrayOfPointers_IsAs19 {
    class Killer : Robot {
        private byte HP;
        private string typeRobot = "Killer";
        private string? specialsText;

        public Killer() {}
        public Killer(string name, uint weight, byte speed, byte HP) : base(name, weight, speed) {
            this.HP = HP;
            base.addInfoAboutRobot($"Robot Type: {typeRobot}");
            base.addInfoAboutRobot($"HP: {HP}");
        }

        public string specials() {
            specialsText += "Смертельный лазер, полет";
            return "Specials: " + specialsText + "\n";
        }
    }
}