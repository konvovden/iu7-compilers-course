class Program
{
    public static void main(String[] args)
    {
        new Inheritance().Start();
    }
}

class A
{
    public int DoSomething(int number)
    {
        return number * number;
    }
}

class B extends A
{
    public int DoSomething(int number)
    {
        return number * 3;
    }
}

class Inheritance 
{
    public int Start()
    {
        A a;
        B b;
        A ab;
        
        a = new A();
        b = new B();
        
        ab = b;
        
        System.out.println(a.DoSomething(5));
        System.out.println(b.DoSomething(5));
        System.out.println(ab.DoSomething(5));
        
        return 0;
    }
}