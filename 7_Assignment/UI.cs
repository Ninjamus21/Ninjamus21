using System;

    
    Seller dealer = new Seller(); 
    Person p1 = new Person(1000000000, "", 0, "", 0);
    Driver p2 = new Driver(false);
    Kvitering kvit = new Kvitering();

    Console.WriteLine("Hello and welcome to the Dealership, What is you name?");
    String PersonName = Console.ReadLine(); 

    Console.WriteLine("Welcome " + PersonName);
    Console.WriteLine("Second of all what is your price range?");
    int Value = Int32.Parse(Console.ReadLine());
    
    // menu 
    while(true){
    Console.WriteLine("Write an action [show, buy, sell, inventory, drive or exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
        Buy();
            break;
        case "show":
        Console.WriteLine();
        Console.WriteLine("These are the available cars, ");
        Console.WriteLine();
        dealer.ShowCar();
            break;
            case "drive":
            if (p1.AvaliableCar == 0){
                Console.WriteLine(" you dont seem to own a car you can drive right now");
            } else {
                p2.TestDrive();
            }
            break;
            case "sell": 
            p1.sell(dealer);
            break;
        case "inventory":
        p1.printInv();
        break;
        case "exit":
            return;
        default: Console.WriteLine("emmm, something here smell fishy, im out.");
            return;
    }
    void Buy(){ 
    Car car = dealer.pitch();
    Console.WriteLine(" Do you want to buy this car? (Y/N) ");
    if (Console.ReadLine() == "Y"){
        if(p1.buy(car)){
            dealer.removeCar(car);
            kvit.printReceipt(car);
        }
    } else{
    }
}
}
Console.ReadLine();