
using System

public class Practice
{
    // function which checks whether an
    // element is even or not. Or you can
    // say it is the specified condition
    private static bool isEven(int i)
    {
        return ((i % 2) == 0);
    }
    
    public static void Main(string[] args)
    {
        // Creating a List of integers
        // Here we are not setting
        // Capacity explicitly
        List<int> firstlist = new List<int>();
  
        // adding elements in firstlist
        firstlist.Add(1);
        firstlist.Add(2);
        firstlist.Add(3);
        firstlist.Add(4);
  
        // Printing the Capacity of firstlist
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);
  
        // Printing the Count of firstlist
        Console.WriteLine("Count Is: " + firstlist.Count);
  
        // Adding some more
        // elements in firstlist
        firstlist.Add(5);
        firstlist.Add(6);
  
        // Printing the Capacity of firstlist
        // It will give output 8 as internally
        // List is resized
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);
  
        // Printing the Count of firstlist
        Console.WriteLine("Count Is: " + firstlist.Count);
        
        // Output:
        // Capacity Is: 4
        // Count Is: 4
        // Capacity Is: 8
        // Count Is: 6
        
        // Creating an List<T> of Integers
        List<int> secondlist = new List<int>();
  
        // Adding elements to List
        secondlist.Add(2);
        secondlist.Add(4);
        secondlist.Add(7);
        secondlist.Add(2);
        secondlist.Add(6);
        secondlist.Add(2);
        secondlist.Add(2);
  
        Console.WriteLine("Elements Present in List:\n");
  
        // Displaying the elements of List
        foreach(int k in secondlist)
        {
            Console.WriteLine(k);
        }
  
        Console.WriteLine(" ");
  
        Console.Write("Result: ");
  
        // Will give the first occurrence of the
        // element of secondist that match the
        // conditions defined by predicate
        Console.WriteLine(secondlist.Find(isEven));
        
//         Output:
//         Elements Present in List:

//         2
//         4
//         7
//         2
//         6
//         2
//         2

//         Result: 2
        
    }
}



