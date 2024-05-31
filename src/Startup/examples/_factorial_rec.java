class Program
{
    public static void main(String[] a)
    {
	    System.out.println(new Factorial().CalculateFactorial(10));
    }
}

class Factorial 
{
    public int CalculateFactorial(int num)
    {
	    int result;
	
	    if (num < 1)
	        result = 1;
	    else 
	        result = num * this.CalculateFactorial(num - 1);
	        
	    return result;
    }

}
