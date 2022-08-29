using System;

namespace Store {
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

        public void BuyCar() 
        {
            if (availability > 0)
            {
                Console.WriteLine(Name + " are in storage and we have " + availability + " left.");
            } else {
                Console.WriteLine("sadly we ran out come back later ;(");
            }
        }
    }
    class CarDealership
    {
        public string actions;
        public CarDealership(string _actions) 
        {
            actions = _actions;
        }
        public void Entry()
        {
            Console.WriteLine("Hello, Welcome to my humble CarDealership, with over 50% high end cars");
        }
        public void ReEntry()
        {
            Console.WriteLine("Is there any thing else i can help with?");
         
        }
        public void Inspect_car()
        {
            Console.WriteLine("What cars are you interested in? ");
            Console.Write("1. Porshe, 2. Mercedes, 3. Audi or 4. BMW?");
        
        }
    }
}

