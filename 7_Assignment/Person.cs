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
 
public void sell(Seller dealer){
printInv();
Console.WriteLine("\nWhat would you like to sell?");
        string key = Console.ReadLine();
        bool sell = false;
        foreach (Car car in cars)
        {
            if (car.Name + car.Generation == key){
                sell = true;
                this.Value = this.Value + car.Price;
                cars.Remove(car);
                Console.WriteLine("You sold your car "+car.Generation+" for "+car.Price+"!");
                dealer.addCar(car);
                break;
            }
             }
        if (sell == false){
            Console.WriteLine("\nYou stumbled a bit on your words:");
            this.sell(dealer);
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
     public void printInv(){
        if(this.cars.Count>0){
        Console.WriteLine("You have these cars in your inventory: ");
        foreach (var item in cars)
        {
            Console.WriteLine(item.Name + " " + item.Generation);
        }
        Console.WriteLine("You Have " + this.Value+ " as your estimated.");
        }else{
        Console.WriteLine("You don't own a car, and " + this.Value+ " in your account");}
    }
public Car CurrentCar = null;
}


