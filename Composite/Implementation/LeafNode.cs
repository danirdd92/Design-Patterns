using Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Implementation
{
    public class LeafNode : NodeComponent
    {

        public LeafNode(int value) : base(value) { }


        public override void Add(NodeComponent node) { }

        public override void CheckEven() { }

        public override bool IsEven()
        {
            if (Value % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Remove(NodeComponent node) { }

        public override int Sum()
        {
            return Value;
        }
    }
}
