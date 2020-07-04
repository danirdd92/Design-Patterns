using Composite.Implementation;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new CompositeNode(2);
            root.Add(new LeafNode(2));
            root.Add(new LeafNode(10));

            var composite = new CompositeNode(4);
            composite.Add(new LeafNode(2));
            composite.Add(new LeafNode(6));

            root.Add(composite);

            Console.WriteLine("Sum of all node values: ", root.Sum() );

            root.CheckEven();
        }
    }
}
// Composite - Ex. 2