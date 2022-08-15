//Un-comment below code and fix the issues
//Push to github

int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    int nextNumber = first + second;
    
    if(count == 0) {
        return nextNumber;
    }else{
        return RecursiveFibonacci(second, nextNumber, count);
    }
}

int lastFibo = RecursiveFibonacci(1,1,5);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 

