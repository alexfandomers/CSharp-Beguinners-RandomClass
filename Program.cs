namespace RandomClass
{
     public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("///random numbers between 1 and 10///");
            var random = new Random();
            for (var i = 0; i < 10; i++)
            
           Console.WriteLine(random.Next(1, 10));

           ////////////////////////////////////////////////////////////////
           Console.WriteLine("//Casting a char as a Int we realized it represents a number//");
           Console.WriteLine("int a is: " + (int)'a');

           ///////////////////////////////////////////////////////////////
           Console.WriteLine("/////Random string/////");
           var randomB = new Random();
           for (var counter = 0; counter < 10; counter++)
           Console.Write((char)random.Next(97, 122));
           Console.WriteLine();
        } 
    }
}