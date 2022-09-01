using System;

public class UI{
    public static void Main(string[] args){
    Console.WriteLine("Hello, and Welcome to our CarDealership. ");
    Console.WriteLine("Do you wish to see our selection?");
    Seller seller = new Seller();
    seller.showCars();
    Person P01 = new Person(100000, "Alucard", true, "Ford Focus", 10000);
    P01.MenuCar();
    
}

}