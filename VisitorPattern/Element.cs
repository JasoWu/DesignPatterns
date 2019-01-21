using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
        public abstract void Print();
    }

    public class ElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素A");
        }
    }

    public class ElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素B");
        }
    }
}
