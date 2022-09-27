// C# code to create a Stack
using System;
using System.Collections;

class GFG {
  
    // Driver code
    public static void Main()
    {
  
        // Creating a Stack
        Stack myStack = new Stack();
  
        // Inserting the elements into the Stack
        myStack.Push("1st Element");
        myStack.Push("2nd Element");
        myStack.Push("3rd Element");
        myStack.Push("4th Element");
        myStack.Push("5th Element");
        myStack.Push("6th Element");
  
        // Displaying the count of elements
        // contained in the Stack
        Console.Write("Total number of elements in the Stack are : ");
  
        Console.WriteLine(myStack.Count);
  
        // Displaying the top element of Stack
        // without removing it from the Stack
        Console.WriteLine("Element at the top is : " + myStack.Peek());
  
        // Displaying the top element of Stack
        // without removing it from the Stack
        Console.WriteLine("Element at the top is : " + myStack.Peek());
  
        // Displaying the count of elements
        // contained in the Stack
        Console.Write("Total number of elements in the Stack are : ");
  
        Console.WriteLine(myStack.Count);
        
        // Output:
        // Total number of elements in the Stack are : 6
        // Element at the top is : 6th Element
        // Element at the top is : 6th Element
        // Total number of elements in the Stack are : 6
        
        
        // Converting the Stack into array
        Object[] arr = myStack.ToArray();
  
        // Displaying the elements in array
        foreach(Object str in arr)
        {
            Console.WriteLine(str);
        }
      
        // Removing all elements from Stack
        myStack.Clear();
      
        // Displaying the count of elements
        // contained in the Stack after
        // removing all the elements
        Console.Write("Total number of elements"+
                         " in the Stack are : ");
  
        Console.WriteLine(myStack.Count);
        
        // Output:
        // Total number of elements in the Stack are : 0
      
      
    }
}
