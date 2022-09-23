class Kvitering{
	public void space(int space){
		for (int i = 0; i < space; i++)
		{
			Console.WriteLine("\n");	
		}
	}
	public void printReceipt(Car car){
		space(2);
		Console.WriteLine("Congrats you are now the owner of "+car.Name);
		space(2);
	}
}
