using System.Collections.Generic;

namespace PseudoBF.CodeDom
{
    public class CodeBlock : List<Statement>
    {
        public CodeBlock(List<Statement> statements)
            : base(statements)
        {
        }
    }
}
