namespace interface22 {
   
    interface IRun {
        const int minSpeed = 0;
        static int maxSpeed { get; set; } = 60;
        void CarMaxSpeed(); 
    }
}