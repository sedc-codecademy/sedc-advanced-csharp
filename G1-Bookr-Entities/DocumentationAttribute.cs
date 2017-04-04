using System;

namespace Entities
{
    internal class DocumentationAttribute : Attribute
    {
        public string Developer { get; set; }
        public string Version { get; set; }
    }
}