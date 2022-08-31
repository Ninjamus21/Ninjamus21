using System;
class Person{
    public int Value;
    public string PersonName;
    public int OwnedCar;
    public int PriceOwnedCar;



public Person(int _Value, string _PersonName, int _OwnedCar, int _PriceOwnedCar)
{
Value =_Value;
PersonName = _PersonName;
OwnedCar = _OwnedCar;
PriceOwnedCar = _PriceOwnedCar;
}
    Person P01 = new Person(100000, "Alucard", 1, 10000);


}