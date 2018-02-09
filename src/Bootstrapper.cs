using Autofac;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Autofac;
using Nancy.OpenApi.Infrastructure;
using NancyTest.Modules;

namespace NancyTest
{
    internal class Bootstrapper : AutofacNancyBootstrapper
    {
//        protected override NancyInternalConfiguration InternalConfiguration
//            => this.WithOpenApi();


        protected override void ConfigureApplicationContainer(ILifetimeScope existingContainer)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HelloModule>()
                   .SingleInstance();

            builder.Update(existingContainer.ComponentRegistry);
        }
    }
}
