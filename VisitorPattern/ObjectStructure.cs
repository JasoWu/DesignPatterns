using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class ObjectStructure
    {
        private ArrayList elements = new ArrayList();

        public ArrayList Elements
        {
            get { return elements; }
        }

        public ObjectStructure()
        {
            Random ro = new Random();
            for(int i = 0; i < 6; i++)
            {
                int ranNum = ro.Next(10);
                if (ranNum > 5)
                {
                    elements.Add(new ElementA());
                }
                else {
                    elements.Add(new ElementB());
                }
            }
        }
    }
}
