using Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Composite.Implementation
{
    public class CompositeNode : NodeComponent
    {
        private List<NodeComponent> _children = new List<NodeComponent>();

        public CompositeNode(int value) : base(value) { }

        public override void Add(NodeComponent node)
        {
            _children.Add(node);
        }

        public override void CheckEven()
        {
            if (IsEven())
            {
                Console.WriteLine("All node values are even");
            }
            else
            {
                Console.WriteLine("Not all node values are even");
            }
        }

        public override bool IsEven()
        {

            if (Value % 2 == 0)
            {
                bool flag = true;

                foreach (var c in _children)
                {
                    flag = c.IsEven();

                    if (flag == false)
                    {
                        return false;
                    }
                }
                return flag;
            }
            else
                return false;

        }

        public override void Remove(NodeComponent node)
        {
            _children.Remove(node);
        }

        public override int Sum()
        {
            var sum = Value;

            foreach (var c in _children)
            {
                switch (c)
                {
                    case CompositeNode n:
                        sum += n.Sum();
                        break;

                    default:
                        sum += c.Value;
                        break;

                }

            }

            return sum;
        }
    }
}
