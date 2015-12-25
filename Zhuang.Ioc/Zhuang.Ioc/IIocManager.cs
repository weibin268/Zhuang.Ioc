using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhuang.Ioc
{
    public interface IIocManager<TIocContainer>
    {
        TIocContainer IocContainer { get; set; }

        void Register<TType, TImpl>(bool singleton = false)
            where TType : class where TImpl : class, TType;
    }
}
