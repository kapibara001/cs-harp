using System;
using System.IO;

namespace files {
    class WorkWithFiles {
        public static void Main() {
        // СТРОКИ
            string word = "Hello"; // По факту - string - это просто массив элементов типа char
            //Console.WriteLine(word[1]); // Подтверждение того, что string - массив типа char
            word += "!";
            Console.WriteLine(word);

            
        // Некоторые функции работы со строками
            //Console.WriteLine(word.Length); // .Length - измерение длины
            //Console.WriteLine(String.Concat(word, "!!")); // .Concat("к чему", "что") Добавление подстрок к строке через String.Concat
            //Console.WriteLine(String.Compare(word, "Hello!!")); // .Compare("что", "с чем") - Сравнение двух строк. Если выдает 0 - строки равны. 
                                                                // Если 1 - то в сравниваемой строке не хватает 1 символа. Если -1 - то на 1 символ больше.

            string people = "Alex,Bob,John";
            string[] names = people.Split(','); // (.Solit("по какому символу")) Разбиение по знаку ",". В курсе эта строка выглядит так: string[] names = people.Split(new char[] {','});
            foreach(string name in names) {
                //Console.WriteLine("Имя - {0}", name);
            }
            people = String.Join(" ", names); // Разделили строку по запятой в 20 строке и соединиили (.Join("как соединить", что соединить)) через пробел в этой строке
            Console.WriteLine(people);

            word += "!       ";
            Console.WriteLine(word.Trim()); //.Trim() - Удаление пробелов, которые мы добавили в 27 строке
            Console.WriteLine(word.Substring(2)); // Обрезание строки word с 0 по 2 индекс (0, 1)
            Console.WriteLine(word.Substring(0, word.Length-1)); // Обрезание только последнего элемента. 0 - начинаем с 0 элемента, ничего не удаляем
                                                                 // word.Length-1 - обрезание последнего символа
        /* 
            .StartsWith() - проверка на то, что строка начинается с символов в скобках (True, False)
            .ToLower(), .ToUpper() - приведение к нижнеему и верхнему регистру соответственно
        */

            
        // РАБОТА С ФАЙЛАМИ
        // Для работы с ними надо подключить библеотеку System.IO;
            using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)) { //Изоляция кода с помощью using()
                // класс FileSteam позволяет открыть файл для чтения или записи. Выделаем память, задаем ему имя и метод открытия(создание, открытие или создание и тп)
                string usertext = "Hello world!";
                // Далее необходимо полученный текст преобразовать в байты(0 и 1) для передачи в файл
                byte[] array = System.Text.Encoding.Default.GetBytes(usertext); // преобразование текста в массив байтов
                
                stream.Write(array, 0, array.Length); // Запись в файл через Write(stream уже создан)
                                                      // array - тут наш текст, 0 - отступ(сколкьо пропускаем от начала), array.Length - до куда
            }

            using(FileStream stream1 = File.OpenRead("info.txt")) { // Открытие файла для получения из него инфы
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Текст из файла:\n" + textFromFile.Trim());
            }


        // Современный вариатив. Его приемуществом является то, что не надо вручную открывать и закрывать потоки FileStream, методы .WriteAllText и .ReadAllText делают это автоматом
        // FileStream нужно применять, когда нужно больше контроля над входными и выходными данными
            string filePath = "myfile2.txt";
            string text = "Putin pidoras, sin shluhi, ya ebal ego";

            //Запись текста в файл
            File.WriteAllText(filePath, text, System.Text.Encoding.Default); 

            // Чтение текста из файла
            string textFromF = File.ReadAllText(filePath, System.Text.Encoding.Default);
            Console.WriteLine(textFromF.Trim());



        // Небольшая практика
        /*
            using(FileStream main_input = new FileStream("myfile.txt", FileMode.OpenOrCreate)) {
                string text = "Putin pidoras, sin shluhi, ya ebal ego";
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                main_input.Write(array, 0, array.Length);
            }
            using(FileStream main_output = File.OpenRead("myfile.txt")) {
                byte[] array = new byte[main_output.Length];
                main_output.Read(array, 0, array.Length);
                string text_fromfile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(text_fromfile.Trim());
            }
        */

            Console.Write("Привет! Что ты хочешь сделать?\n0 - отмена, 1 - создать файлик или добавить в него что-то, 2 - прочитать все из файлика: ");
            string theme = Console.ReadLine();

            switch(theme) {
                case "1":
                    using (FileStream filename = new FileStream("theme.txt", FileMode.OpenOrCreate)) {
                        Console.Write("Напишите задачу, которую хотите поместить в файл: ");
                        string exersize = Console.ReadLine();
                        exersize += "\n";
                        byte[] array = System.Text.Encoding.Default.GetBytes(exersize);
                        filename.Write(array, 0, array.Length);
                    }
                    break;

                case "2":
                    string alltext = File.ReadAllText("theme.txt", System.Text.Encoding.Default);
                    if (alltext == "" || alltext == " ") {
                        Console.WriteLine("В файле пусто");
                    } else {
                        Console.WriteLine(alltext.Trim());
                    }
                    break;
`                    
                default:
                    Console.WriteLine("Отмена.");
                    break;
            }
                
            
            
        }
    }
}