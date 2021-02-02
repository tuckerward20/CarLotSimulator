using System;
namespace CarLotSimulator
{
    public class Car
    {
        private static int ID = 0;
        private int myId = 0;

        public Car()
        { 
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
            ID++;
            this.myId = ID;

        }
        

        public int MyId
        {
            get { return myId; }
        }

        public int Year
        {
            get;
            set;
        }
        public string Make
        {
            get;
            set;
        }
        public string Model
        {
            get;
            set;
        }
        public string EngineNoise
        {
            get;
            set;
        }
        public string HonkNoise
        {
            get;
            set;
        }
        public bool IsDrivable
        {
            get;
            set;
        }
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
