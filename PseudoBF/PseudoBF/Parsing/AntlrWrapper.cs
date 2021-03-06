﻿using System.IO;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using PseudoBF.CodeDom;
using System.Collections.Generic;

namespace PseudoBF.Parsing
{
    internal class AntlrWrapper : IParser
    {
        private object GetProgramElement(ITree node)
        {
            switch (node.Type)
            {
                case PseudoBFParser.PROGRAM_IMAG:
                {
                    List<Subroutine> subroutines = new List<Subroutine>();
                    for (int i = 0; i < node.ChildCount; i++)
                    {
                        subroutines.Add((Subroutine)GetProgramElement(node.GetChild(i)));
                    }
                    return new ProgramModel(subroutines);
                }

                case PseudoBFParser.SUBROUTINE_IMAG:
                {
                    string id = node.GetChild(1).Text;
                    VariableList argList = (VariableList)GetProgramElement(node.GetChild(2));
                    VariableList locals = (VariableList)GetProgramElement(node.GetChild(3));
                    CodeBlock code = (CodeBlock)GetProgramElement(node.GetChild(4));
                    return new CustomSubroutine(id, argList.Arguments, locals.Arguments, code);
                }

                case PseudoBFParser.VARS_IMAG:
                {
                    VariableList args = new VariableList();
                    for (int i = 0; i < node.ChildCount; i++)
                    { args.Arguments.Add(new VariableName(node.GetChild(i).Text)); }
                    return args;
                }

                case PseudoBFParser.VALUES_IMAG:
                {
                    ValueList args = new ValueList();
                    for (int i = 0; i < node.ChildCount; i++)
                    { args.Values.Add((IValue)GetProgramElement(node.GetChild(i))); }
                    return args;
                }

                case PseudoBFParser.LOCALS_IMAG:
                {
                    VariableList args = new VariableList();
                    if (node.ChildCount > 0)
                    { args = (VariableList)GetProgramElement(node.GetChild(0)); }
                    return args;
                }

                case PseudoBFParser.BLOCK_IMAG:
                {
                    List<Statement> statements = new List<Statement>();
                    for (int i = 0; i < node.ChildCount; i++)
                    { statements.Add((Statement)GetProgramElement(node.GetChild(i))); }
                    return new CodeBlock(statements);
                }

                case PseudoBFParser.ASSIGN_IMAG:
                {
                    VariableName dest = new VariableName(node.GetChild(0).Text);
                    IValue source = (IValue)GetProgramElement(node.GetChild(1));
                    return new Assignment(source, dest);
                }

                case PseudoBFParser.VARIABLE_IMAG:
                {
                    return new VariableName(node.GetChild(0).Text);
                };

                case PseudoBFParser.NUMBER_IMAG:
                {
                    byte value = byte.Parse(node.GetChild(0).Text);
                    return new Number(value);
                };

                case PseudoBFParser.CALL_IMAG:
                {
                    string funcName = node.GetChild(0).Text;
                    ValueList args = (ValueList)GetProgramElement(node.GetChild(1));
                    return new Call(funcName, args.Values);
                }

                case PseudoBFParser.OPERATOR_CALL_IMAG:
                {
                    string opName = node.GetChild(0).Text;
                    List<IValue> parameters = new List<IValue>();
                    parameters.Add((IValue)GetProgramElement(node.GetChild(1)));
                    parameters.Add((IValue)GetProgramElement(node.GetChild(2)));
                    return new Call(opName, parameters);
                }

                case PseudoBFParser.RETURN_IMAG:
                {
                    IValue value = (IValue)GetProgramElement(node.GetChild(0));
                    return new Return(value);
                }

                case PseudoBFParser.IF_IMAG:
                {
                    IValue value = (IValue)GetProgramElement(node.GetChild(0));
                    CodeBlock code = (CodeBlock)GetProgramElement(node.GetChild(1));
                    CodeBlock codeElse;
                    if (node.ChildCount > 2) { codeElse = (CodeBlock)GetProgramElement(node.GetChild(2)); }
                    else { codeElse = new CodeBlock(new List<Statement>()); }

                    return new If(value, code, codeElse);
                }

                case PseudoBFParser.ELSE_IMAG:
                {
                    return GetProgramElement(node.GetChild(0));
                }

                case PseudoBFParser.WHILE_IMAG:
                {
                    IValue value = (IValue)GetProgramElement(node.GetChild(0));
                    CodeBlock code = (CodeBlock)GetProgramElement(node.GetChild(1));
                    While w = new While(value, code);

                    return w;
                }

                case PseudoBFParser.PRINT_IMAG:
                {
                    return new Print(node.GetChild(0).Text);
                }

                case PseudoBFParser.STRING_IMAG:
                {
                    return node.GetChild(0).Text;
                }
            }

            throw new ArgumentException("Unknown item type");
        }

        private CommonTreeNodeStream AntlrParse(string code)
        {
            ICharStream stream = new ANTLRStringStream(code);
            PseudoBFLexer lexer = new PseudoBFLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            PseudoBFParser parser = new PseudoBFParser(tokens);
            PseudoBFParser.program_return parseResult = parser.program();

            return new CommonTreeNodeStream(parseResult.Tree);
        }

        private ProgramModel ConvertToCodeModel(CommonTreeNodeStream stream)
        {
            List<Subroutine> subroutines = new List<Subroutine>();

            CommonTree programTree = (CommonTree)stream.TreeSource;

            return (ProgramModel)GetProgramElement(programTree);
        }

        public ProgramModel Parse(string code, List<Subroutine> predefinedSubroutines)
        {
            var tree = AntlrParse(code);
            ProgramModel model = ConvertToCodeModel(tree);
            model.Subroutines.AddRange(predefinedSubroutines);
            model.Link();
            return model;
        }
    }
}
