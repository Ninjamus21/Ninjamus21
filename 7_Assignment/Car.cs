using System;

namespace Store
{
    class Car
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



        public Car(string _Name, int _TopSpeed, string _Generation, int _Price, int _Kilometers, int _HorsePower, string _GearType, float _Zero_Hundred, int _availability)
        {
            Name = _Name;
            TopSpeed = _TopSpeed;
            Generation = _Generation;
            Price = _Price;
            Kilometers = _Kilometers;
            HorsePower = _HorsePower;
            GearType = _GearType;
            Zero_Hundred = _Zero_Hundred;
            availability = _availability;
        }
        }
}

