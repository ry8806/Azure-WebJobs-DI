using Autofac;
using WebJob1.Implementations;

namespace WebJob1
{
    public static class ContainerConfig
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register the functions class - WebJobs will discover our triggers this way
            builder.RegisterType<Functions>();

            builder.RegisterType<HelloGenerator>().As<IStringGenerator>().SingleInstance();

            return builder.Build();
        }
    }
}
