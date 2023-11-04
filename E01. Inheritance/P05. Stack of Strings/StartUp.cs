using System;
using System.Collections.Generic;

namespace CustomStack
{
   public class StartUp
    {
       public static void Main(string[] args)
        {

            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            List<string> addedList = new List<string>() { "1", "5", "10" };
            stack.AddRange(addedList);
            Console.WriteLine(stack.IsEmpty());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
