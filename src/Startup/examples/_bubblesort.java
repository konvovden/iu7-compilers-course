class Program
{
    public static void main(String[] a)
    {
	    new BubbleSort().Start(10);
    }
}

class BubbleSort
{
    public int Start(int size)
    {
        int[] array;
        
        array = this.InitArray(size);
        
        this.PrintArray(array);
        
        this.SortArray(array);
        
        System.out.println(false);
        this.PrintArray(array);
        
        return 0;
    }
    
    public int[] InitArray(int size)
    {
        int i;
        int[] array;
        
        array = new int[size];
        
        i = 0;
        while (i < size)
        {
            array[i] = System.randomInt(20);
            i = i + 1;
        }
	
	    return array;	
    }
    
    public int PrintArray(int[] array)
    {
        int i;
        
        i = 0;
        
        while(i < array.length)
        {
            System.out.println(array[i]);
            i = i + 1;
        }   
        
        return 0;
    }
    
    public int SortArray(int[] array)
    {
        int i;
        int j;
        int tmp;
        
        i = 0;
        
        while (i < array.length - 1)
        {
            j = i + 1;
            
            while (j < array.length)
            {
                if (array[j] < array[i])
                {
                    tmp = array[j];
                    array[j] = array[i];
                    array[i] = tmp;
                }
                else {}
                
                j = j + 1;
            }
        
            i = i + 1;
        }
        
        return 0;
    }
}