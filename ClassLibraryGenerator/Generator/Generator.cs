using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGenerator.Generator
{
    public class Generator
    {
        public List<string> Content { get; set;}
        public string Path { get; set;}
        public TypeFormat Format { get; set;}
        public TypeCharacter Character { get; set;} 
        public Generator() { }
    }
}
