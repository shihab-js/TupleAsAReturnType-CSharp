using System;

namespace TupleAsAReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the method
            var person = GetPerson();
        }

        //create a method with tuple return type
        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Shihab", "Programmer");
        }
    }
}
