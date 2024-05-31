class Program
{
    public static void main(String[] args)
    {
        new Inheritance().Start();
    }
}

class A
{
    int value;

    public int SetValue(int number)
    {
        value = number;
        
        return 0;
    }

    public int DoNothing()
    {
        return 55;
    }

    public int DoSomething(int number)
    {
        return number * number;
    }
}

class B extends A
{
    public int DoSomething(int number)
    {
        return number * value;
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
        
        b.SetValue(3);
        
        System.out.println(a.DoSomething(5));
        System.out.println(b.DoSomething(5));
        System.out.println(ab.DoSomething(5));
        
        System.out.println(a.DoNothing());
        System.out.println(b.DoNothing());
        System.out.println(ab.DoNothing());
        
        return 0;
    }
}