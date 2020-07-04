using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original DB:\n" + new string('-', 10));
            var e = new EmployeeDatabase();
            e.GetEmployees();

            Console.WriteLine("Shallow Copy DB:\n" + new string('-', 10));
            var s = e.ShallowCopy();
            s.GetEmployees();

            Console.WriteLine("Deep Copy DB:\n" + new string('-', 10));
            var d = e.DeepCopy();
            d.GetEmployees();
        }
    }
}
// Prototype - Ex. 4