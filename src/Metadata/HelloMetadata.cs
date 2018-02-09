using System.Collections.Generic;
using Nancy.OpenApi;

namespace NancyTest.Metadata
{
    public class HelloMetadata : ModuleMetadata
    {
        public readonly PathMetadata PostMetadata = new PathMetadata
        {
            OperationId = "addTest",
            Summary = "Add a test object",
            Consumes = new List<string> { "application/json", "application/xml" },
            Produces = new List<string> { "application/json", "application/xml" },
            Tags = new List<string> { "Test" }
        };

        public HelloMetadata()
        {
            Get["/"] = PostMetadata;
        }
    }
}
