namespace interface22 {
    /* 
    Интерфейсы максимально схожи с абстрактными классами.
    Интерфейс - ссылочный тип, который может определять некоторый функционал - набор методов и свойств 
    БЕЗ РЕАЛИЗАЦИИ. Затем этот функционал реализуют классы и структуры, которые применяют данные интерфейсы. 
    
    !!!     Внутри одного класса можно реализовать сразу несколько интерфейсов.

    Стоит отметить, что если интерфейс имеет приватные методы и свойства (то есть с модификатором private), 
    то они должны иметь реализацию по умолчанию. То же самое относится к статическим 
    методам (не обязательно приватным).

    Создание интерфейса - просто "словарь" методов и полей, которые нужно реализовать при подключении конструктора

    */
    interface IRun { // Инициализация интерфейса словом interface. Обычно название дается по правилу I + название интерфейса
        const int minSpeed = 0;     // минимальная скорость
        // статическая переменная
        static int maxSpeed { get; set; } = 60;   // максимальная скорость

        void CarMaxSpeed(); 
    }
}