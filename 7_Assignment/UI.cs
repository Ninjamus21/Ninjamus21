using System;

public class UI{
    public static void Main(string[] args){
    Seller dealer = new Seller(); //This class you need to create yourself!
while(true){

    Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
            Car firstCar = dealer.AvailableCars[0];
            Car myNewCar = dealer.Buy(firstCar);
            Console.WriteLine("Yay my car cost " + myNewCar.Price + "kr");
            break;
        case "sell":
        
            break;
        case "exit":
            return;
        default:
            break;
    }
}

    
}

}