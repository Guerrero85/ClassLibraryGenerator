using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibraryGenerator.Generator
{
    public class Generator
    {
        public List<string> Content { get; set; }
        public string Path { get; set; }
        public TypeFormat Format { get; set; }
        public TypeCharacter Character { get; set; }
        public void Save()
        {
            string result = "";
        }
        private string GentJson() => JsonSerializer.Serialize(Content);
        private string GetPipe() => Content.Aggregate((accumulator, current) => accumulator + "|" + current);
    }
}
