public class Driver{

    Boolean driverstate = false;
public Driver(Boolean _driverstate){
    driverstate = _driverstate;
}
    Person p1 = new Person(10000, "dan", 0, "", 0);
   
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
            Console.WriteLine("you are now entering" + p1.CurrentCar);
            break;
        case "Drive":
            break;
        case "1-100":
        
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

