using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    ///  抽象访问者
    /// </summary>
    public interface IVisitor
    {
        void Visit(ElementA a);
        void Visit(ElementB b);
    }


    /// <summary>
    /// 具体访问者
    /// </summary>
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA a)
        {
            a.Print();
        }

        public void Visit(ElementB b)
        {
            b.Print();
        }
    }
}
