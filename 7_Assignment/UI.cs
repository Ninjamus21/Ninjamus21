using System;

    Person p1 = new Person(10000, "dan", 0, "", 0);
    Seller dealer = new Seller(); 
    
while(true){

    Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
           // Car c = dealer.Buy();
          //  p1.CurrentCar = c;
            break;
        case "show":
            dealer.ShowCar();
            break;
        case "exit":
            return;
        default:
            return;
    }
}

    Console.ReadLine();
