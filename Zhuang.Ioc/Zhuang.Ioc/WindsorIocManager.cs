using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhuang.Ioc
{
    public class WindsorIocManager : IIocManager<IWindsorContainer>
    {
        public IWindsorContainer IocContainer
        {
            get; set;
        }

        public WindsorIocManager()
        {
            IocContainer = new WindsorContainer();
        }

        public void Register<TType, TImpl>(bool singleton = false)
          where TType : class
          where TImpl : class, TType
        {
            var registraion = Component.For<TType, TImpl>().ImplementedBy<TImpl>();
            if (singleton)
            {
                registraion = registraion.LifestyleSingleton();
            }
            IocContainer.Register(registraion);
        }

        public T Resolve<T>()
        {
            return IocContainer.Resolve<T>();
        }
    }
}
