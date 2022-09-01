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
public void MenuCar(){
    Seller seller = new Seller();
    Console.WriteLine("Write an action [Buy, sell, Trade or exit]");
while(true){

    string input = Console.ReadLine();
    Person P01 = new Person(100000, "Alucard", 1, "Ford Focus", 10000);
    switch (input)
    {
        case "Buy":
            Console.WriteLine("Okay Perfect, what car are you interrested in?");
            Console.WriteLine("These are the avaliable cars"); 
            Console.WriteLine();
            seller.PreviewCar();
            // insert buy mecanic via method 
            Console.WriteLine("Type the car you what to preview");
            Console.ReadLine();
            Console.WriteLine("Yea sure? Type again");
            break;
        case "1":
        seller.car1();
            break;
        case "Trade":
            if (AvaliableCar < 1){
                Console.WriteLine("Hmm, that kinda homeless i see here that you dont currently own a car! ");
            } else {
                Console.WriteLine("Nice, do you want to trade your " + OwnedCar + " at the price of " + PriceOwnedCar);
            }
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            return;
            }
        }
    }
}



