using System;

class Seller
{
    public List<Car> AvailableCars = new List<Car>();
    private float _money;
    Person p1 = new Person(100000, "Dan", 0 ,"none", 0);
public Seller()
{
<<<<<<< Updated upstream
=======
Person P01 = new Person(100000, "Alucard", 1, "Ford Focus", 10000);
>>>>>>> Stashed changes
    #region porshe
    Car car01 = new Car("Porsche Taycan", 230, "2021", 819900, 0, 326, "Automatic", 5.4f, 1,"");
    Car car02 = new Car("Porshe Macan Turbo", 266, "2013", 749900, 98000, 400, "Automatic", 4.8f, 1,"");
    Car car03 = new Car("Porsche 911 Targa 4 GTS", 307, "2022", 3453427, 0, 480, "Automatic", 3.5f, 1, "");
    #endregion porsche
    #region Mercedes

    Car car04 = new Car("Mercedes A180", 190, "2014", 169900, 111800, 109, "Automatic", 11.6f, 1, "");
    Car car05 = new Car("Mercedes S560", 250, "2018", 2299900, 11000, 469, "Automatic", 4.6f, 1, "");
    Car car06 = new Car("Mercedes E220 d", 240, "2019", 457000, 65000, 194, "Automatic", 7.3f, 1, "");
    #endregion Mercedes
    #region Audi

    Car car07 = new Car("Audi A3", 203, "2008", 59900, 180000, 125, "Automatic", 9.5f, 2, "");
    Car car08 = new Car("Audi SQ5", 250, "2018", 719000, 51000, 354, "Automatic", 5.4f, 1, "");
    Car car09 = new Car("Audi e-tron GT", 245, "2022", 1084900, 1000, 476, "Automatic", 4.1f, 1, "");
    #endregion Audi
    #region BMW

    Car car10 = new Car("BMW 320d", 230, "2014", 184900, 186000, 184, "Automatic", 7.6f, 1, "");
    Car car11 = new Car("BMW X6", 236, "2012", 459500, 114000, 304, "Automatic", 6.5f, 2, "");
    Car car12 = new Car("BMW iX", 200, "2022", 819000, 9000, 326, "Automatic", 6.1f, 1, "");
    #endregion BMW
<<<<<<< Updated upstream
    AvailableCars.Add(car01);
    AvailableCars.Add(car02);
    AvailableCars.Add(car03);
    AvailableCars.Add(car04);
    AvailableCars.Add(car05);
    AvailableCars.Add(car06);
    AvailableCars.Add(car07);
    AvailableCars.Add(car08);
    AvailableCars.Add(car09);
    AvailableCars.Add(car10);
    AvailableCars.Add(car11);
    AvailableCars.Add(car12);
    
    
}
public Car Buy(Car Car)
    { //Public buy method, which takes a Car as an argument/paramater
        Car returnValueCar = null;
        foreach (Car c in AvailableCars)
        {   
        if(p1.Value > Car.Price){
            if(Car.id == c.id){
                returnValueCar = c;

=======
    
    

public void showCars(){

while(true){

    Console.WriteLine("Write an action [Show or exit]");
   string input = Console.ReadLine();
    switch (input)
        {
            case "Show":
                Console.WriteLine("These are the avaliable cars"); 
                Console.WriteLine("1. " + car01.Name + car01.availability);
                Console.WriteLine("2. " + car02.Name + car01.availability);
                Console.WriteLine("3. " + car03.Name + car01.availability);
                Console.WriteLine("4. " + car04.Name + car01.availability);
                Console.WriteLine("5. " + car05.Name + car01.availability);
                Console.WriteLine("6. " + car06.Name + car01.availability);
                Console.WriteLine("7. " + car07.Name + car01.availability);
                Console.WriteLine("8. " + car08.Name + car01.availability);
                Console.WriteLine("9. " + car09.Name + car01.availability);
                Console.WriteLine("10. " + car10.Name + car01.availability);
                Console.WriteLine("11. " + car11.Name + car01.availability);
                Console.WriteLine("12. " + car12.Name + car01.availability);
                return;
            case "exit":
                return;
            default:
                return;
>>>>>>> Stashed changes
            }
        }
        }
        Console.ReadLine();
        return returnValueCar;
        
    }
<<<<<<< Updated upstream
=======
    public void PreviewCar(){
    Console.WriteLine("These are the avaliable cars"); 
                Console.WriteLine("1. " + car01.Name);
                Console.WriteLine("2. " + car02.Name);
                Console.WriteLine("3. " + car03.Name);
                Console.WriteLine("4. " + car04.Name);
                Console.WriteLine("5. " + car05.Name);
                Console.WriteLine("6. " + car06.Name);
                Console.WriteLine("7. " + car07.Name);
                Console.WriteLine("8. " + car08.Name);
                Console.WriteLine("9. " + car09.Name);
                Console.WriteLine("10. " + car10.Name);
                Console.WriteLine("11. " + car11.Name);
                Console.WriteLine("12. " + car12.Name);
    }
    public void car1(){
        Console.WriteLine("Excellent choice " + car01.Name + " with at topspeed of " + car01.TopSpeed + "kilometers pr hour. It is the best of its generation of " + car01.Generation + ". But dont think you'll get away this easy it still cost " + car01.Price + "Kr. It has droven " + car01.Kilometers + "km and pulls " + car01.HorsePower + " horses. It has an " + car01.GearType + " motor");
        if (car01.availability == 0){
            Console.WriteLine("Yea but we dont currently have the " + car01.Name + " in store, sorry");
            } else {
                Console.WriteLine("We have " + car01.Name + " in store are you interrested?");
            }
        while(true){

    Console.WriteLine("the " + car01.Name + "is at the cost of " + car01.Price + "do you want to buy type Buy and if not exit");
    string input = Console.ReadLine();

    switch (input)
    {
        case "Buy":
       
           if (car01.Price > P01.Value){
            Console.WriteLine("You obtained " + car01.Name + "you currently own " + car01 + " and " + P01.OwnedCar );
            car01.availability -- 1;
           } else {

           }
           break;
        case "exit":
            return;
        default:
            return;
    }
}
 }
>>>>>>> Stashed changes
}
