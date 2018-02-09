using Nancy;

namespace NancyTest.Modules
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["Hello world", "/"] = ctx => "hello world!";
        }
    }
}
