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
	    int i;
	    
	    i = 1;
	    result = 1;
	    
	    while(i < num)
	    {
	        System.out.println(i);
	        result = result * i;
	        i = i + 1;
	    }
	
	    return result;
    }

}
