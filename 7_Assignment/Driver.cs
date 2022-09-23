public class Driver{

    Boolean driverstate = false;
public Driver(Boolean _driverstate){
    driverstate = _driverstate;
}
    Person p1 = new Person(10000, "dan", 1, "", 100000);
   
   public void TestDrive(){
        if (p1.CurrentCar != null){
            driverstate = true;
        }
while(driverstate == true){

    Console.WriteLine("To use car first enter the car by typing: EnterCar");
    string input = Console.ReadLine();

    switch (input)
    {
        case "EnterCar":
            Console.WriteLine("you are now entering" + p1.CurrentCar.Name);
            break;
        case "Drive":
            Console.WriteLine("Driving off in the distance with in your " + p1.CurrentCar.Name);
            break;
        case "1-100":
            Console.WriteLine("Holding still ready to accelerate, the " + p1.CurrentCar.Name + "hits 100 in" + p1.CurrentCar.Zero_Hundred + " in seconds");
            return;
        default:
            return;
        }
    }
}
    void ExitCar(){
        driverstate = false;
    }
}

