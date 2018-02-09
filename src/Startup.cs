using Microsoft.AspNetCore.Builder;
using Nancy.Owin;

namespace NancyTest
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
}
