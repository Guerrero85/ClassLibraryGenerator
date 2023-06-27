using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGenerator.Generator
{
    public class GeneratorDirectory
    {
        private IBuilderGenerator _builderGenerator;

        public GeneratorDirectory(IBuilderGenerator generatorBuilder)
        {
            SetBuilder(generatorBuilder);
        }
        public void SetBuilder(IBuilderGenerator builderGenerator) => _builderGenerator = builderGenerator;
        public void CreateSimpleJson(List<string> content, string path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContent(content);
            _builderGenerator.SetPath(path);
            _builderGenerator.SetFormat(TypeFormat.Json);
        }
        public void CreateSimplePipe(List<string> content, string path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContent(content);
            _builderGenerator.SetPath(path);
            _builderGenerator.SetFormat(TypeFormat.Pipes);
            _builderGenerator.SetCharacter(TypeCharacter.Uppercase);
        }
    }
}
