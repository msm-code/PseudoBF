using System.Collections.Generic;

namespace PseudoBF.CodeDom
{
    public enum StatementType
    {
        Assignment,
        Call,
        Return,
        If,
        While,
        Print
    }

    internal interface ILinkable
    {
        void LinkTo(ProgramModel model);
    }

    public abstract class Statement
    {
        public abstract StatementType Type { get; }
    }

    public class Assignment : Statement, ILinkable
    {
        public Assignment(IValue source, VariableName destination)
        {
            this.Source = source;
            this.Destination = destination;
        }

        public IValue Source { get; private set; }
        public VariableName Destination { get; private set; }

        public override StatementType Type
        {
            get { return StatementType.Assignment; }
        }

        void ILinkable.LinkTo(ProgramModel model)
        {
            if (Source is ILinkable)
            { (Source as ILinkable).LinkTo(model); }
        }
    }

    public class Call : Statement, IValue, ILinkable
    {
        private string procName;

        public Call(string procName, List<IValue> parameters)
        {
            this.procName = procName;
            this.Parameters = parameters;
        }

        public Subroutine Subroutine { get; private set; }
        public List<IValue> Parameters { get; private set; }

        public override StatementType Type
        {
            get { return StatementType.Call; }
        }

        ValueType IValue.Type
        {
            get { return ValueType.FunctionCall; }
        }

        void ILinkable.LinkTo(ProgramModel model)
        {
            this.Subroutine = model.GetSubroutine(procName);
        }
    }

    public class Return : Statement
    {
        public Return(IValue value)
        {
            this.Value = value;
        }

        public IValue Value { get; private set; }

        public override StatementType Type
        {
            get { return StatementType.Return; }
        }
    }

    public class If : Statement, ILinkable
    {
        public If(IValue test, CodeBlock codeIf)
        {
            this.Test = test;
            this.CodeIf = codeIf;
            this.CodeElse = new CodeBlock(new List<Statement>());
        }

        public If(IValue test, CodeBlock codeIf, CodeBlock codeElse)
        {
            this.Test = test;
            this.CodeIf = codeIf;
            this.CodeElse = codeElse;
        }

        public IValue Test { get; private set; }
        public CodeBlock CodeIf { get; private set; }
        public CodeBlock CodeElse { get; private set; }

        public override StatementType Type
        {
            get { return StatementType.If; }
        }

        void ILinkable.LinkTo(ProgramModel model)
        {
            if (Test is ILinkable)
            { (Test as ILinkable).LinkTo(model); }

            foreach (Statement s in CodeIf)
            { if(s is ILinkable) (s as ILinkable).LinkTo(model); }

            foreach (Statement s in CodeElse)
            { if (s is ILinkable) (s as ILinkable).LinkTo(model); }
        }
    }

    public class While : Statement, ILinkable
    {
        public While(IValue test, CodeBlock body)
        {
            this.Test = test;
            this.Body = body;
        }

        public IValue Test { get; private set; }
        public CodeBlock Body { get; private set; }

        public override StatementType Type
        {
            get { return StatementType.While; }
        }

        public void LinkTo(ProgramModel model)
        {
            if (Test is ILinkable)
            { (Test as ILinkable).LinkTo(model); }

            foreach (Statement s in Body)
            { if (s is ILinkable) (s as ILinkable).LinkTo(model); }
        }
    }

    public class Print : Statement
    {
        private string text;

        public Print(string text)
        {
            this.text = text;
        }

        public string Text { get { return text; } }

        public override StatementType Type
        {
            get { return StatementType.Print; }
        }
    }
}
