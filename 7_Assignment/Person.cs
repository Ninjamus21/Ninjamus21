using System;
public class Person{
    public int Value;
    public string PersonName;
    public int AvaliableCar;
    public string OwnedCar;
    public int PriceOwnedCar;



public Person(int _Value, string _PersonName, int _AvaliableCar, string _OwnedCar, int _PriceOwnedCar)
{
this.Value =_Value;
this.PersonName = _PersonName;
this.AvaliableCar = _AvaliableCar;
this.OwnedCar = _OwnedCar;
this.PriceOwnedCar = _PriceOwnedCar;

}

public Car CurrentCar = null;
}


