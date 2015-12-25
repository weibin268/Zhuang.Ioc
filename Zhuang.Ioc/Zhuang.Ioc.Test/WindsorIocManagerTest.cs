using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor.Installer;
using Castle.Windsor;
using Zhuang.Ioc.Test.TestClass;
using Castle.MicroKernel.Registration;

namespace Zhuang.Ioc.Test
{
    [TestClass]
    public class WindsorIocManagerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            WindsorIocManager manager = new WindsorIocManager();
            manager.Register<IFly,Bird>();

            var fly = manager.Resolve<IFly>();
            fly.Fly();

        }
    }
}