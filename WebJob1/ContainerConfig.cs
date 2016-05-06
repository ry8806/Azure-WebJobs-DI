using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJob1.Implementations;

namespace WebJob1
{
    public static class ContainerConfig
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register the functions class
            //builder.RegisterType<Functions>();

            builder.RegisterType<HelloGenerator>().As<IStringGenerator>().SingleInstance();

            return builder.Build();
        }
    }
}
