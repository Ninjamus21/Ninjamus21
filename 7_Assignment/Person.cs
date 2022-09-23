using System;
public class Person{
    public int Value;
    public string PersonName;
    public int AvaliableCar;
    public string OwnedCar;
    public int PriceOwnedCar;
    public List<Car> cars=new List<Car>();


public Person(int _Value, string _PersonName, int _AvaliableCar, string _OwnedCar, int _PriceOwnedCar)
{
this.Value =_Value;
this.PersonName = _PersonName;
this.AvaliableCar = _AvaliableCar;
this.OwnedCar = _OwnedCar;
this.PriceOwnedCar = _PriceOwnedCar;

}
public void sell()
    {
if (AvaliableCar == 1){
        char Answer;
        string Ans;
        string FirstName,LastName,OwnedCar;
        Console.Write("Which Brand:  ");
        OwnedCar = Console.ReadLine();
        Console.Write("First Name: ");
        FirstName = Console.ReadLine();
        Console.Write("Last Name:  ");
        LastName = Console.ReadLine();

        Console.Write("Do you Wish to Sell your own car??? (1=Yes/0=No)? ");

        Ans = Console.ReadLine();
        Answer = char.Parse(Ans);

        if(Answer == '1')
        Console.WriteLine("Full Name:   {0} {1}, BilMærke: {2}, Det er super, vi sender dig en købskontrakt.", FirstName, LastName, OwnedCar);
    } else { 
        System.Console.WriteLine("You dont currently own a car!");
    }
    }
    public bool buy(Car carToBuy){
        if(this.Value>=carToBuy.Price){
        this.Value -= carToBuy.Price;
        Console.WriteLine("That cost " + carToBuy.Price + "kr.");
        this.cars.Add(carToBuy);
        carToBuy.Price = carToBuy.Price/2;
        Console.WriteLine("You have just added " + carToBuy.Name + carToBuy.Generation + " to your inventory.");
        return true;
        }else{
            Console.WriteLine("Currently im only reading insuffient funds.");
            return false;  
        }
    }
    
public Car CurrentCar = null;
}


