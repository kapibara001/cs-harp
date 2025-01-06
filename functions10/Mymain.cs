using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;

namespace project {
    class Prog {
        static void Main() {
            /*
            List<string> namelist = new List<string> {
                "Привет!", "Я", "Твой", "Друг"
            };

            namelist.Add("Это не правда!");

            foreach(string el in namelist) {
                Console.WriteLine(el);
            */

            Print(); // Вызов функции print()
            Print();
            Print();
            string word = "Падлыова";
            ushort age = 11 ;
            PrintWord(word, age);
        }

        public static void Print() {        // public - за счет него мы можем обращаться к этой функции(методу) из всех классов. 
            Console.WriteLine("Hello!");    // static - он говорит о том, что мы можем обратиться у функции просто по ее имени 
        }                                   // void - Признак того, что функция ничего не должна возвращать
            
        public static void PrintWord(string word, ushort age) { // Указанные в скобках данные функция как бы ожидает для дальнейшей работы с ними. 
                                                                // В случае, если данные требуются, но они не указаны - будет ошибка
            Console.WriteLine("Привет! Ваше слово: {0} и вам {1} лет.", word, age);
        }
    }
}
