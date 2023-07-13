namespace StackApp
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Pop();
            intStack.Pop();
            Console.WriteLine(intStack.IsEmpty()); // Output: False


            Stack<string> stringStack = new Stack<string>();
            Console.WriteLine(stringStack.Pop());
            stringStack.Push(1+"Yagnesh");
            stringStack.Push(2+"Pancholi");
            stringStack.Push(3+"Yagu");
            stringStack.Pop();
            stringStack.Pop();
            Console.WriteLine(stringStack.IsEmpty()); // Output: False
            Console.ReadLine();
        }
    }
}