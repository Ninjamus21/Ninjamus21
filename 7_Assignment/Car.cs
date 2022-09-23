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



        public Car(string _Name, int _TopSpeed, string _Generation, int _Price, int _Kilometers, int _HorsePower, string _GearType, float _Zero_Hundred, int _availability)
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
        public void information(){
            System.Console.WriteLine("Our " + Name + " from the generation of " + Generation + " rides smoothly");
            System.Console.WriteLine("You cam expect a topspeed of " + TopSpeed + " it has droven " + Kilometers + "km");
            System.Console.WriteLine("But it will cost ya " + Price + "kr. lige nu har vi " + availability + " tilbage");
        }

        }



