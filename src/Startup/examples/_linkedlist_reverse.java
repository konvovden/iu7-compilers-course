class Program 
{
	public static void main(String[] args) 
	{
		new ReverseLinkedList().Start(10);
	}
}

class LinkedListNode
{
    int _data;
    LinkedListNode _next;
    boolean _hasNext;
    
    public int Init(int data)
    {
        _data = data;
        _hasNext = false;
        
        return 0;
    }
    
    public int GetData()
    {
        return _data;
    }
    
    public LinkedListNode GetNext()
    {
        return _next;
    }
    
    public boolean HasNext()
    {
        return _hasNext;
    }
    
    public int SetNext(LinkedListNode node)
    {
        _next = node;
        _hasNext = true;
        
        return 0;
    }
    
    public int RemoveNext()
    {
        _hasNext = false;
        
        return 0;
    }
}

class LinkedList 
{
    LinkedListNode _root;
    
    public int Init(int size)
    {
        int i;
        LinkedListNode current;
        LinkedListNode next;
                
        _root = new LinkedListNode();
        _root.Init(System.randomInt(20));
        
        i = 1;
        current = _root;
        
        while (i < size)
        {
            next = new LinkedListNode();
            next.Init(System.randomInt(20));
            
            current.SetNext(next);
            
            current = next;
            
            i = i + 1;
        }
        
        return 0;
    }
    
    public int Print()
    {
        LinkedListNode current;
        
        current = _root;
        
        while (current.HasNext())
        {
            System.out.println(current.GetData());
            
            current = current.GetNext();
        }
        
        System.out.println(current.GetData());
        
        return 0;
    }
    
    public int Reverse()
    {
        LinkedListNode current;
        LinkedListNode prev;
        boolean hasPrev;
        LinkedListNode next;
        
        current = _root;
        prev = new LinkedListNode();
        hasPrev = false;
        
        while (current.HasNext())
        {
            next = current.GetNext();
            
            if (hasPrev)
                current.SetNext(prev);
            else
                current.RemoveNext();
                
            prev = current;
            hasPrev = true;
            
            current = next;
        }
        
        current.SetNext(prev);
        _root = current;
        
        return 0;
    }
}

class ReverseLinkedList 
{
    public int Start(int size)
    {
        LinkedList list;
        
        list = new LinkedList();
        list.Init(size);
        
        list.Print();
        
        list.Reverse();
        
        System.out.println(false);
        list.Print();
        
        return 0;
    }
}

