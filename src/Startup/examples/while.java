class Program 
{
	public static void main(String[] args) 
	{
	    System.out.println(new A().DoSomething(10));
	}
}

class A
{
    public int DoSomething(int a)
    {
        int b;
        
        b = a + 5;
        c = b;
        
        return b;
    }
}
