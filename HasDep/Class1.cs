using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Pidgin;

namespace HasDep
{
    [Generator]
    public class Class1 : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context) {
            // use Pidgin
            try {
                Pidgin.Parser.Digit.ParseOrThrow("3");
            } catch (ParseException p) {
                // ignore
            }
        }
        public void Initialize(GeneratorInitializationContext context) {
            // nothing
        }
    }
}
