using System;

    public class Car
    {
        public string Name;
        public int TopSpeed;
        public string Generation;
        public int Price;
        public int Kilometers;
        public int HorsePower;
        public string GearType;
        public float Zero_Hundred;
        public int availability;
        public string id;



        public Car(string _Name, int _TopSpeed, string _Generation, int _Price, int _Kilometers, int _HorsePower, string _GearType, float _Zero_Hundred, int _availability, string id)
        {
            this.Name = _Name;
            this.TopSpeed = _TopSpeed;
            this.Generation = _Generation;
            this.Price = _Price;
            this.Kilometers = _Kilometers;
            this.HorsePower = _HorsePower;
            this.GearType = _GearType;
            this.Zero_Hundred = _Zero_Hundred;
            this.availability = _availability;
            this.id = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            
        }
        void InspectCarName(){
            Console.WriteLine();
        }
        }



