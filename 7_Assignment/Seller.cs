using System;

class Seller
{
    public List<Car> AvailableCars = new List<Car>();
    private float _money;
    Person p1 = new Person(100000, "Dan", 0 ,"none", 0);
public Seller()
{
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

            }
        }
        }
        Console.ReadLine();
        return returnValueCar;
        
    }
}
