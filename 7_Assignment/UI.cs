using System;

class UI{
    public static void Main(string[] args){
    Console.WriteLine("Hello, and Welcome to our CarDealership. ");
    Console.WriteLine("Do you wish to see our selection?");
    Seller seller = new Seller();
    seller.showCars();
    
}
}