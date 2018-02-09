using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Autofac;
using Nancy.ModelBinding.DefaultBodyDeserializers;
using Nancy.Responses.Negotiation;
using Nancy.Serialization.ProtoBuf;
using Nancy.Serialization.ProtoBuf.BodyDeserializers;
using NancyTest.Modules;

namespace NancyTest
{
    internal class Bootstrapper : AutofacNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(ILifetimeScope existingContainer)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HelloModule>()
                   .SingleInstance();

            builder.Update(existingContainer.ComponentRegistry);
        }

        protected override IEnumerable<Type> BodyDeserializers
        {
            get
            {
                yield return typeof(ProtobufNetBodyDeserializer);
                yield return typeof(JsonBodyDeserializer);
            }
        }

        protected IEnumerable<Type> ResponseProcessors
        {
            get
            {
                yield return typeof(ProtoBufProcessor);
                yield return typeof(JsonProcessor);
            }
        }

        protected override Func<ITypeCatalog, NancyInternalConfiguration> InternalConfiguration
            => NancyInternalConfiguration.WithOverrides(x => x.ResponseProcessors = ResponseProcessors.ToArray());

        protected override IEnumerable<Type> ViewEngines
        {
            get { yield break; }
        }
    }
}
