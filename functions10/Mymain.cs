using System;
using System.Collections.Generic;

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

            Print(); // Вызов функции print() если бы не было обязательного параметра

            string word = "Павел Дуров";
            ushort age = 11 ;
            PrintWord(word, age); // Вызов функции с обязательными параметрами

            float res = MathematicOperations(12.125125f, 125533.12412f);
            Printres(res.ToString());


            byte[] nums1 = {5, 7, 1, 3, 5}; // Практическое задание
            byte res1= ArraySum(nums1);
            Printres(res1.ToString());

            float[] nums2 = {5.6f, 7.412f, 1, 12.46f, 24, 6, 1};
            float res2 = ArraySum(nums2);
            Printres(res2.ToString());
        }

        public static void Printres(string word) {        // public - за счет него мы можем обращаться к этой функции(методу) из всех классов. 
            Console.WriteLine(word);                      // static - он говорит о том, что мы можем обратиться у функции просто по ее имени 
        }                                                 // void - Признак того, что функция ничего не должна возвращать
        
        public static void Print() {
            Console.WriteLine("Hello!");
        }

            
        public static void PrintWord(string word, ushort age) { // Указанные в скобках данные функция как бы ожидает для дальнейшей работы с ними. 
                                                                // В случае, если данные требуются, но они не указаны - будет ошибка
            Console.WriteLine("Привет! Ваше слово: {0} и вам {1} лет.", word, age);
        }

        public static float MathematicOperations(float x, float y) {
            return x + y;
        }



    // Практическое задание. Все переменные, связанные с этой функцией, находятся в Main()
        public static byte ArraySum(byte[] arr) { // Также можно ПЕРЕЗАГРУЖАТЬ функции, то есть создавать ту же функцию с тем же именем, но менять тип данных
            byte sum = 0;                         // Наример в этой функции обязателен тип byte, но можно сделать эту же функцию, но с типом float к примеру.
            foreach (byte el in arr) {
                sum += el;
            }
            return sum;
        } 

         public static float ArraySum(float[] arr) {  // Перезагрузка функции.
            float sum = 0;                         
            foreach (float el in arr) {
                sum += el;
            }
            return sum;
        } 
    }
}
