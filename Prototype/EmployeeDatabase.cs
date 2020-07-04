using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Prototype
{
    public class EmployeeDatabase : Prototype
    {
        private List<Employee> _employees = new List<Employee> {
                new Employee(1494209, "Mark Rubens", 15_000),
                new Employee(3829532, "Dana Fried", 15_750),
                new Employee(6058285, "Steven Son", 20_500),
                new Employee(8784462, "Sarah Koy", 12_000),
                new Employee(5728465, "Bob Jacksoon",17_000),
                new Employee(5129137, "Jack Bones", 40_000)
            };


        public override List<Employee> GetEmployees()
        {
            var sorted = Sort();
            foreach (var e in sorted)
            {
                Console.WriteLine($"ID: {e.ID}, Name:{e.Name}, Salary: {e.Salary}");
            }

            return _employees;
        }

        public override IEnumerable<Employee> Sort()
        {
            int count = _employees.Count();

            IOrderedEnumerable<Employee> sortedlist;

            if (count < 100)
            {
                return sortedlist = _employees.OrderBy(e => e.ID);

            }
            else if (count >= 100 && count <= 200)
            {
                return sortedlist = _employees.OrderBy(e => e.Name);
            }
            else
            {
                return sortedlist = _employees.OrderBy(e => e.Salary);
            }
        }


        public override Prototype ShallowCopy()
        {
            return MemberwiseClone() as Prototype;
        }
        public override Prototype DeepCopy()
        {
            var copy = MemberwiseClone() as EmployeeDatabase;

            var copiedEmpoloyees = new List<Employee>();


            foreach (var e in _employees)
            {
                copiedEmpoloyees.Add(new Employee(e.ID, e.Name, e.Salary));
            }

            copy._employees = copiedEmpoloyees;

            return copy;
        }

    }

}