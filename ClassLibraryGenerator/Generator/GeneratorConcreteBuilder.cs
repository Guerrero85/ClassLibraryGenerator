using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGenerator.Generator
{
    public class GeneratorConcreteBuilder : IBuilderGenerator
    {
        private Generator _generator;
        public GeneratorConcreteBuilder()
        {
            Reset();
        }
        public void Resete()=> _generator = new Generator();
        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetCharacter(TypeCharacter character = TypeCharacter.Normal)
        {
            throw new NotImplementedException();
        }

        public void SetContent(List<string> content)
        {
            throw new NotImplementedException();
        }

        public void SetFormat(TypeFormat format)
        {
            throw new NotImplementedException();
        }

        public void SetPath(string path)
        {
            throw new NotImplementedException();
        }
    }
}
