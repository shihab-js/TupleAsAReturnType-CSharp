using System;

namespace TupleAsAReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the method
            var person = GetPerson();

            //Print the value
            Console.WriteLine($"id = {person.Item1}");
            Console.WriteLine($"Name = {person.Item2}");
            Console.WriteLine($"Profession = {person.Item3}");
        }

        //create a method with tuple return type
        static Tuple<int, string, string> GetPerson()
        {
            //return a tuple
            return Tuple.Create(1, "Shihab", "Programmer");
        }
    }
}
