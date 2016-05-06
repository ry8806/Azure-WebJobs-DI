using Autofac;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJob1
{
    public class AutofacActivator : IJobActivator
    {
        private readonly IContainer _container;

        public AutofacActivator(IContainer container)
        {
            _container = container;
        }

        public T CreateInstance<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
