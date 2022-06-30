using System;

namespace MechSharingCode.Utils
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HttpRequestDefinitionAttribute: Attribute
    {
        public string Route { get; set; }

        public HttpRequestDefinitionAttribute(string route) { this.Route = route; }

    }
}