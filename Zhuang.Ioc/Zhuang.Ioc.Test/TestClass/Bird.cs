using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhuang.Ioc.Test.TestClass
{
    public class Bird : IFly
    {
        public void Fly()
        {
            Console.WriteLine("flying");
        }
    }
}
