using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhuang.Ioc.Test.TestClass
{
    public class TestInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                .Where(Component.IsInSameNamespaceAs<Bird>())
                                .WithService.DefaultInterfaces()
                                .LifestyleTransient());
        }
    }
}
