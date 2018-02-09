using Nancy;
using NancyTest.Model;

namespace NancyTest.Modules
{
    public sealed class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", _ => Negotiate.WithModel(new Message { Msg = "Hello World!" }));
        }
    }
}
