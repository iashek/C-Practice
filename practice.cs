
using System

public class Practice
{
    public static void Main(string[] args)
    {
        LinkedList<int> list=new LinkedList<int>();
        for(int i=0;i<5;i++)
          list.AddLast(i*10);
        for(int i=5;i<10;i++)
          list.AddFirst(i*10);
        
        foreach(int i in list)
            Console.Write(i+"   ");
        Console.WriteLine();
        
        
    }
}
