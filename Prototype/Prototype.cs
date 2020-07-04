using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Prototype
    {
        public abstract Prototype ShallowCopy();
        public abstract Prototype DeepCopy();
        public abstract List<Employee> GetEmployees();
        public abstract IEnumerable<Employee> Sort();
    }
}
