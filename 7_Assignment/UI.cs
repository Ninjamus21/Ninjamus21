using System;

    
    Seller dealer = new Seller(); 
    Person p1 = new Person(10000, "", 0, "", 0);
    Driver p2 = new Driver(false);

    Console.WriteLine("Hello and welcome to the Dealership, What is you name?");
    String PersonName = Console.ReadLine(); 

    Console.WriteLine("Welcome " + PersonName);
while(true){

    Console.WriteLine("Write an action [show, buy, sell, drive or exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
        Console.WriteLine("To buy a car you need to copy the correspondent car ID ");
        Console.WriteLine();
        Console.WriteLine("If you haven't got one you can find them under the show section"); 
        //dealer.Buy();
            break;
        case "show":
        Console.WriteLine();
        Console.WriteLine("These are the available cars, " + " if you are interested in purchase one copy the car ID.");
        Console.WriteLine();
            dealer.ShowCar();
            break;
            case "drive":
            if (p1.AvaliableCar == 0){
                Console.WriteLine("you dont seem to own a car you can drive right now");
            } else {
                p2.TestDrive();
            }
            break;
        case "exit":
            return;
        default:
            return;
    }
}

    Console.ReadLine();
