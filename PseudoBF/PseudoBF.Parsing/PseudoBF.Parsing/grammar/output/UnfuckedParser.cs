// $ANTLR 3.3 Nov 30, 2010 12:45:30 D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g 2011-08-04 19:35:21

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  PseudoBF.Parsing 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class PseudoBFParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM_IMAG", "BLOCK_IMAG", "SUBROUTINE_IMAG", "LOCALS_IMAG", "VARS_IMAG", "CALL_IMAG", "OPERATOR_CALL_IMAG", "ASSIGN_IMAG", "RETURN_IMAG", "NUMBER_IMAG", "VARIABLE_IMAG", "IF_IMAG", "ELSE_IMAG", "WHILE_IMAG", "STRING_IMAG", "VALUES_IMAG", "PRINT_IMAG", "ID", "FUNCTION_KW", "PROCEDURE_KW", "LOCALS_KW", "IF_KW", "ELSE_KW", "WHILE_KW", "OPERATOR", "NUMBER", "RETURN_KW", "PRINT_KW", "STRING", "CHAR", "IDCHAR", "DIGIT", "UNDERSCORE", "WHITESPACE", "'('", "')'", "','", "':'", "'{'", "';'", "'}'", "'='"
	};
	public const int EOF=-1;
	public const int T__38=38;
	public const int T__39=39;
	public const int T__40=40;
	public const int T__41=41;
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int PROGRAM_IMAG=4;
	public const int BLOCK_IMAG=5;
	public const int SUBROUTINE_IMAG=6;
	public const int LOCALS_IMAG=7;
	public const int VARS_IMAG=8;
	public const int CALL_IMAG=9;
	public const int OPERATOR_CALL_IMAG=10;
	public const int ASSIGN_IMAG=11;
	public const int RETURN_IMAG=12;
	public const int NUMBER_IMAG=13;
	public const int VARIABLE_IMAG=14;
	public const int IF_IMAG=15;
	public const int ELSE_IMAG=16;
	public const int WHILE_IMAG=17;
	public const int STRING_IMAG=18;
	public const int VALUES_IMAG=19;
	public const int PRINT_IMAG=20;
	public const int ID=21;
	public const int FUNCTION_KW=22;
	public const int PROCEDURE_KW=23;
	public const int LOCALS_KW=24;
	public const int IF_KW=25;
	public const int ELSE_KW=26;
	public const int WHILE_KW=27;
	public const int OPERATOR=28;
	public const int NUMBER=29;
	public const int RETURN_KW=30;
	public const int PRINT_KW=31;
	public const int STRING=32;
	public const int CHAR=33;
	public const int IDCHAR=34;
	public const int DIGIT=35;
	public const int UNDERSCORE=36;
	public const int WHITESPACE=37;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public PseudoBFParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public PseudoBFParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	void CreateTreeAdaptor(ref ITreeAdaptor adaptor) {}

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return PseudoBFParser.tokenNames; } }
	public override string GrammarFileName { get { return "D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g"; } }



 	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_program() {}
    protected virtual void Leave_program() {}

    // $ANTLR start "program"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:34:8: public program : subroutines EOF -> ^( PROGRAM_IMAG subroutines ) ;
    [GrammarRule("program")]
    public PseudoBFParser.program_return program()
    {

        PseudoBFParser.program_return retval = new PseudoBFParser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EOF2=null;
        PseudoBFParser.subroutines_return subroutines1 = default(PseudoBFParser.subroutines_return);

        object EOF2_tree=null;
        RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_subroutines=new RewriteRuleSubtreeStream(adaptor,"rule subroutines");
    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(34, 63);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:34:16: ( subroutines EOF -> ^( PROGRAM_IMAG subroutines ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:34:18: subroutines EOF
    		{
    		DebugLocation(34, 18);
    		PushFollow(Follow._subroutines_in_program136);
    		subroutines1=subroutines();
    		PopFollow();

    		stream_subroutines.Add(subroutines1.Tree);
    		DebugLocation(34, 30);
    		EOF2=(IToken)Match(input,EOF,Follow._EOF_in_program138);  
    		stream_EOF.Add(EOF2);



    		{
    		// AST REWRITE
    		// elements: subroutines
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 34:34: -> ^( PROGRAM_IMAG subroutines )
    		{
    			DebugLocation(34, 37);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:34:37: ^( PROGRAM_IMAG subroutines )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(34, 39);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM_IMAG, "PROGRAM_IMAG"), root_1);

    			DebugLocation(34, 52);
    			adaptor.AddChild(root_1, stream_subroutines.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(34, 63);
    	} finally { DebugExitRule(GrammarFileName, "program"); }
    	return retval;

    }
    // $ANTLR end "program"

    public class subroutines_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_subroutines() {}
    protected virtual void Leave_subroutines() {}

    // $ANTLR start "subroutines"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:36:1: subroutines : ( subroutine )* ;
    [GrammarRule("subroutines")]
    private PseudoBFParser.subroutines_return subroutines()
    {

        PseudoBFParser.subroutines_return retval = new PseudoBFParser.subroutines_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        PseudoBFParser.subroutine_return subroutine3 = default(PseudoBFParser.subroutine_return);


    	try { DebugEnterRule(GrammarFileName, "subroutines");
    	DebugLocation(36, 14);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:37:2: ( ( subroutine )* )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:37:4: ( subroutine )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(37, 4);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:37:4: ( subroutine )*
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if (((LA1_0>=FUNCTION_KW && LA1_0<=PROCEDURE_KW)))
    			{
    				alt1=1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch ( alt1 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:37:4: subroutine
    				{
    				DebugLocation(37, 4);
    				PushFollow(Follow._subroutine_in_subroutines155);
    				subroutine3=subroutine();
    				PopFollow();

    				adaptor.AddChild(root_0, subroutine3.Tree);

    				}
    				break;

    			default:
    				goto loop1;
    			}
    		}

    		loop1:
    			;

    		} finally { DebugExitSubRule(1); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(37, 14);
    	} finally { DebugExitRule(GrammarFileName, "subroutines"); }
    	return retval;

    }
    // $ANTLR end "subroutines"

    public class subroutine_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_subroutine() {}
    protected virtual void Leave_subroutine() {}

    // $ANTLR start "subroutine"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:39:1: subroutine : subroutine_type ID variable_list locals_def code_block -> ^( SUBROUTINE_IMAG subroutine_type ID variable_list locals_def code_block ) ;
    [GrammarRule("subroutine")]
    private PseudoBFParser.subroutine_return subroutine()
    {

        PseudoBFParser.subroutine_return retval = new PseudoBFParser.subroutine_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID5=null;
        PseudoBFParser.subroutine_type_return subroutine_type4 = default(PseudoBFParser.subroutine_type_return);
        PseudoBFParser.variable_list_return variable_list6 = default(PseudoBFParser.variable_list_return);
        PseudoBFParser.locals_def_return locals_def7 = default(PseudoBFParser.locals_def_return);
        PseudoBFParser.code_block_return code_block8 = default(PseudoBFParser.code_block_return);

        object ID5_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_variable_list=new RewriteRuleSubtreeStream(adaptor,"rule variable_list");
        RewriteRuleSubtreeStream stream_subroutine_type=new RewriteRuleSubtreeStream(adaptor,"rule subroutine_type");
        RewriteRuleSubtreeStream stream_code_block=new RewriteRuleSubtreeStream(adaptor,"rule code_block");
        RewriteRuleSubtreeStream stream_locals_def=new RewriteRuleSubtreeStream(adaptor,"rule locals_def");
    	try { DebugEnterRule(GrammarFileName, "subroutine");
    	DebugLocation(39, 78);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:40:2: ( subroutine_type ID variable_list locals_def code_block -> ^( SUBROUTINE_IMAG subroutine_type ID variable_list locals_def code_block ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:40:4: subroutine_type ID variable_list locals_def code_block
    		{
    		DebugLocation(40, 4);
    		PushFollow(Follow._subroutine_type_in_subroutine165);
    		subroutine_type4=subroutine_type();
    		PopFollow();

    		stream_subroutine_type.Add(subroutine_type4.Tree);
    		DebugLocation(40, 20);
    		ID5=(IToken)Match(input,ID,Follow._ID_in_subroutine167);  
    		stream_ID.Add(ID5);

    		DebugLocation(40, 23);
    		PushFollow(Follow._variable_list_in_subroutine169);
    		variable_list6=variable_list();
    		PopFollow();

    		stream_variable_list.Add(variable_list6.Tree);
    		DebugLocation(40, 37);
    		PushFollow(Follow._locals_def_in_subroutine171);
    		locals_def7=locals_def();
    		PopFollow();

    		stream_locals_def.Add(locals_def7.Tree);
    		DebugLocation(40, 48);
    		PushFollow(Follow._code_block_in_subroutine173);
    		code_block8=code_block();
    		PopFollow();

    		stream_code_block.Add(code_block8.Tree);


    		{
    		// AST REWRITE
    		// elements: variable_list, ID, code_block, locals_def, subroutine_type
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 41:3: -> ^( SUBROUTINE_IMAG subroutine_type ID variable_list locals_def code_block )
    		{
    			DebugLocation(41, 6);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:41:6: ^( SUBROUTINE_IMAG subroutine_type ID variable_list locals_def code_block )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(41, 8);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SUBROUTINE_IMAG, "SUBROUTINE_IMAG"), root_1);

    			DebugLocation(41, 24);
    			adaptor.AddChild(root_1, stream_subroutine_type.NextTree());
    			DebugLocation(41, 40);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(41, 43);
    			adaptor.AddChild(root_1, stream_variable_list.NextTree());
    			DebugLocation(41, 57);
    			adaptor.AddChild(root_1, stream_locals_def.NextTree());
    			DebugLocation(41, 68);
    			adaptor.AddChild(root_1, stream_code_block.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(41, 78);
    	} finally { DebugExitRule(GrammarFileName, "subroutine"); }
    	return retval;

    }
    // $ANTLR end "subroutine"

    public class subroutine_type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_subroutine_type() {}
    protected virtual void Leave_subroutine_type() {}

    // $ANTLR start "subroutine_type"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:43:1: subroutine_type : ( FUNCTION_KW | PROCEDURE_KW );
    [GrammarRule("subroutine_type")]
    private PseudoBFParser.subroutine_type_return subroutine_type()
    {

        PseudoBFParser.subroutine_type_return retval = new PseudoBFParser.subroutine_type_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set9=null;

        object set9_tree=null;

    	try { DebugEnterRule(GrammarFileName, "subroutine_type");
    	DebugLocation(43, 15);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:44:2: ( FUNCTION_KW | PROCEDURE_KW )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(44, 2);
    		set9=(IToken)input.LT(1);
    		if ((input.LA(1)>=FUNCTION_KW && input.LA(1)<=PROCEDURE_KW))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set9));
    			state.errorRecovery=false;
    		}
    		else
    		{
    			MismatchedSetException mse = new MismatchedSetException(null,input);
    			DebugRecognitionException(mse);
    			throw mse;
    		}


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(45, 15);
    	} finally { DebugExitRule(GrammarFileName, "subroutine_type"); }
    	return retval;

    }
    // $ANTLR end "subroutine_type"

    public class variable_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_variable_list() {}
    protected virtual void Leave_variable_list() {}

    // $ANTLR start "variable_list"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:47:1: variable_list : ( '(' ')' -> ^( VARS_IMAG ) | '(' ID ( ',' ID )* ')' -> ^( VARS_IMAG ( ID )+ ) );
    [GrammarRule("variable_list")]
    private PseudoBFParser.variable_list_return variable_list()
    {

        PseudoBFParser.variable_list_return retval = new PseudoBFParser.variable_list_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal10=null;
        IToken char_literal11=null;
        IToken char_literal12=null;
        IToken ID13=null;
        IToken char_literal14=null;
        IToken ID15=null;
        IToken char_literal16=null;

        object char_literal10_tree=null;
        object char_literal11_tree=null;
        object char_literal12_tree=null;
        object ID13_tree=null;
        object char_literal14_tree=null;
        object ID15_tree=null;
        object char_literal16_tree=null;
        RewriteRuleITokenStream stream_40=new RewriteRuleITokenStream(adaptor,"token 40");
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
        RewriteRuleITokenStream stream_38=new RewriteRuleITokenStream(adaptor,"token 38");

    	try { DebugEnterRule(GrammarFileName, "variable_list");
    	DebugLocation(47, 43);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:47:14: ( '(' ')' -> ^( VARS_IMAG ) | '(' ID ( ',' ID )* ')' -> ^( VARS_IMAG ( ID )+ ) )
    		int alt3=2;
    		try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    		int LA3_0 = input.LA(1);

    		if ((LA3_0==38))
    		{
    			int LA3_1 = input.LA(2);

    			if ((LA3_1==39))
    			{
    				alt3=1;
    			}
    			else if ((LA3_1==ID))
    			{
    				alt3=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 3, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(3); }
    		switch (alt3)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:47:16: '(' ')'
    			{
    			DebugLocation(47, 16);
    			char_literal10=(IToken)Match(input,38,Follow._38_in_variable_list213);  
    			stream_38.Add(char_literal10);

    			DebugLocation(47, 20);
    			char_literal11=(IToken)Match(input,39,Follow._39_in_variable_list215);  
    			stream_39.Add(char_literal11);



    			{
    			// AST REWRITE
    			// elements: 
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 47:24: -> ^( VARS_IMAG )
    			{
    				DebugLocation(47, 27);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:47:27: ^( VARS_IMAG )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(47, 29);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARS_IMAG, "VARS_IMAG"), root_1);

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:48:4: '(' ID ( ',' ID )* ')'
    			{
    			DebugLocation(48, 4);
    			char_literal12=(IToken)Match(input,38,Follow._38_in_variable_list226);  
    			stream_38.Add(char_literal12);

    			DebugLocation(48, 8);
    			ID13=(IToken)Match(input,ID,Follow._ID_in_variable_list228);  
    			stream_ID.Add(ID13);

    			DebugLocation(48, 11);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:48:11: ( ',' ID )*
    			try { DebugEnterSubRule(2);
    			while (true)
    			{
    				int alt2=2;
    				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    				int LA2_0 = input.LA(1);

    				if ((LA2_0==40))
    				{
    					alt2=1;
    				}


    				} finally { DebugExitDecision(2); }
    				switch ( alt2 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:48:12: ',' ID
    					{
    					DebugLocation(48, 12);
    					char_literal14=(IToken)Match(input,40,Follow._40_in_variable_list231);  
    					stream_40.Add(char_literal14);

    					DebugLocation(48, 16);
    					ID15=(IToken)Match(input,ID,Follow._ID_in_variable_list233);  
    					stream_ID.Add(ID15);


    					}
    					break;

    				default:
    					goto loop2;
    				}
    			}

    			loop2:
    				;

    			} finally { DebugExitSubRule(2); }

    			DebugLocation(48, 21);
    			char_literal16=(IToken)Match(input,39,Follow._39_in_variable_list237);  
    			stream_39.Add(char_literal16);



    			{
    			// AST REWRITE
    			// elements: ID
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 48:25: -> ^( VARS_IMAG ( ID )+ )
    			{
    				DebugLocation(48, 28);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:48:28: ^( VARS_IMAG ( ID )+ )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(48, 30);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARS_IMAG, "VARS_IMAG"), root_1);

    				DebugLocation(48, 40);
    				if ( !(stream_ID.HasNext) )
    				{
    					throw new RewriteEarlyExitException();
    				}
    				while ( stream_ID.HasNext )
    				{
    					DebugLocation(48, 40);
    					adaptor.AddChild(root_1, stream_ID.NextNode());

    				}
    				stream_ID.Reset();

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(48, 43);
    	} finally { DebugExitRule(GrammarFileName, "variable_list"); }
    	return retval;

    }
    // $ANTLR end "variable_list"

    public class value_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_value_list() {}
    protected virtual void Leave_value_list() {}

    // $ANTLR start "value_list"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:50:1: value_list : ( '(' ')' -> ^( VALUES_IMAG ) | '(' value ( ',' value )* ')' -> ^( VALUES_IMAG ( value )+ ) );
    [GrammarRule("value_list")]
    private PseudoBFParser.value_list_return value_list()
    {

        PseudoBFParser.value_list_return retval = new PseudoBFParser.value_list_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal17=null;
        IToken char_literal18=null;
        IToken char_literal19=null;
        IToken char_literal21=null;
        IToken char_literal23=null;
        PseudoBFParser.value_return value20 = default(PseudoBFParser.value_return);
        PseudoBFParser.value_return value22 = default(PseudoBFParser.value_return);

        object char_literal17_tree=null;
        object char_literal18_tree=null;
        object char_literal19_tree=null;
        object char_literal21_tree=null;
        object char_literal23_tree=null;
        RewriteRuleITokenStream stream_40=new RewriteRuleITokenStream(adaptor,"token 40");
        RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
        RewriteRuleITokenStream stream_38=new RewriteRuleITokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_value=new RewriteRuleSubtreeStream(adaptor,"rule value");
    	try { DebugEnterRule(GrammarFileName, "value_list");
    	DebugLocation(50, 54);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:51:2: ( '(' ')' -> ^( VALUES_IMAG ) | '(' value ( ',' value )* ')' -> ^( VALUES_IMAG ( value )+ ) )
    		int alt5=2;
    		try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    		int LA5_0 = input.LA(1);

    		if ((LA5_0==38))
    		{
    			int LA5_1 = input.LA(2);

    			if ((LA5_1==39))
    			{
    				alt5=1;
    			}
    			else if ((LA5_1==ID||LA5_1==NUMBER))
    			{
    				alt5=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 5, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(5); }
    		switch (alt5)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:51:4: '(' ')'
    			{
    			DebugLocation(51, 4);
    			char_literal17=(IToken)Match(input,38,Follow._38_in_value_list255);  
    			stream_38.Add(char_literal17);

    			DebugLocation(51, 8);
    			char_literal18=(IToken)Match(input,39,Follow._39_in_value_list257);  
    			stream_39.Add(char_literal18);



    			{
    			// AST REWRITE
    			// elements: 
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 51:12: -> ^( VALUES_IMAG )
    			{
    				DebugLocation(51, 15);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:51:15: ^( VALUES_IMAG )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(51, 17);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VALUES_IMAG, "VALUES_IMAG"), root_1);

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:52:4: '(' value ( ',' value )* ')'
    			{
    			DebugLocation(52, 4);
    			char_literal19=(IToken)Match(input,38,Follow._38_in_value_list268);  
    			stream_38.Add(char_literal19);

    			DebugLocation(52, 8);
    			PushFollow(Follow._value_in_value_list270);
    			value20=value();
    			PopFollow();

    			stream_value.Add(value20.Tree);
    			DebugLocation(52, 14);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:52:14: ( ',' value )*
    			try { DebugEnterSubRule(4);
    			while (true)
    			{
    				int alt4=2;
    				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    				int LA4_0 = input.LA(1);

    				if ((LA4_0==40))
    				{
    					alt4=1;
    				}


    				} finally { DebugExitDecision(4); }
    				switch ( alt4 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:52:15: ',' value
    					{
    					DebugLocation(52, 15);
    					char_literal21=(IToken)Match(input,40,Follow._40_in_value_list273);  
    					stream_40.Add(char_literal21);

    					DebugLocation(52, 19);
    					PushFollow(Follow._value_in_value_list275);
    					value22=value();
    					PopFollow();

    					stream_value.Add(value22.Tree);

    					}
    					break;

    				default:
    					goto loop4;
    				}
    			}

    			loop4:
    				;

    			} finally { DebugExitSubRule(4); }

    			DebugLocation(52, 27);
    			char_literal23=(IToken)Match(input,39,Follow._39_in_value_list279);  
    			stream_39.Add(char_literal23);



    			{
    			// AST REWRITE
    			// elements: value
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 52:31: -> ^( VALUES_IMAG ( value )+ )
    			{
    				DebugLocation(52, 34);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:52:34: ^( VALUES_IMAG ( value )+ )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(52, 36);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VALUES_IMAG, "VALUES_IMAG"), root_1);

    				DebugLocation(52, 48);
    				if ( !(stream_value.HasNext) )
    				{
    					throw new RewriteEarlyExitException();
    				}
    				while ( stream_value.HasNext )
    				{
    					DebugLocation(52, 48);
    					adaptor.AddChild(root_1, stream_value.NextTree());

    				}
    				stream_value.Reset();

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(52, 54);
    	} finally { DebugExitRule(GrammarFileName, "value_list"); }
    	return retval;

    }
    // $ANTLR end "value_list"

    public class locals_def_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_locals_def() {}
    protected virtual void Leave_locals_def() {}

    // $ANTLR start "locals_def"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:54:1: locals_def : ( ':' LOCALS_KW variable_list -> ^( LOCALS_IMAG variable_list ) | -> ^( LOCALS_IMAG ) );
    [GrammarRule("locals_def")]
    private PseudoBFParser.locals_def_return locals_def()
    {

        PseudoBFParser.locals_def_return retval = new PseudoBFParser.locals_def_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal24=null;
        IToken LOCALS_KW25=null;
        PseudoBFParser.variable_list_return variable_list26 = default(PseudoBFParser.variable_list_return);

        object char_literal24_tree=null;
        object LOCALS_KW25_tree=null;
        RewriteRuleITokenStream stream_LOCALS_KW=new RewriteRuleITokenStream(adaptor,"token LOCALS_KW");
        RewriteRuleITokenStream stream_41=new RewriteRuleITokenStream(adaptor,"token 41");
        RewriteRuleSubtreeStream stream_variable_list=new RewriteRuleSubtreeStream(adaptor,"rule variable_list");
    	try { DebugEnterRule(GrammarFileName, "locals_def");
    	DebugLocation(54, 20);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:55:2: ( ':' LOCALS_KW variable_list -> ^( LOCALS_IMAG variable_list ) | -> ^( LOCALS_IMAG ) )
    		int alt6=2;
    		try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    		int LA6_0 = input.LA(1);

    		if ((LA6_0==41))
    		{
    			alt6=1;
    		}
    		else if ((LA6_0==42))
    		{
    			alt6=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(6); }
    		switch (alt6)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:55:4: ':' LOCALS_KW variable_list
    			{
    			DebugLocation(55, 4);
    			char_literal24=(IToken)Match(input,41,Follow._41_in_locals_def297);  
    			stream_41.Add(char_literal24);

    			DebugLocation(55, 8);
    			LOCALS_KW25=(IToken)Match(input,LOCALS_KW,Follow._LOCALS_KW_in_locals_def299);  
    			stream_LOCALS_KW.Add(LOCALS_KW25);

    			DebugLocation(55, 18);
    			PushFollow(Follow._variable_list_in_locals_def301);
    			variable_list26=variable_list();
    			PopFollow();

    			stream_variable_list.Add(variable_list26.Tree);


    			{
    			// AST REWRITE
    			// elements: variable_list
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 55:32: -> ^( LOCALS_IMAG variable_list )
    			{
    				DebugLocation(55, 35);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:55:35: ^( LOCALS_IMAG variable_list )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(55, 37);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOCALS_IMAG, "LOCALS_IMAG"), root_1);

    				DebugLocation(55, 49);
    				adaptor.AddChild(root_1, stream_variable_list.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:56:4: 
    			{

    			{
    			// AST REWRITE
    			// elements: 
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 56:4: -> ^( LOCALS_IMAG )
    			{
    				DebugLocation(56, 7);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:56:7: ^( LOCALS_IMAG )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(56, 9);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOCALS_IMAG, "LOCALS_IMAG"), root_1);

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(56, 20);
    	} finally { DebugExitRule(GrammarFileName, "locals_def"); }
    	return retval;

    }
    // $ANTLR end "locals_def"

    public class code_block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_code_block() {}
    protected virtual void Leave_code_block() {}

    // $ANTLR start "code_block"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:58:1: code_block : '{' ( statement ';' )* '}' -> ^( BLOCK_IMAG ( statement )* ) ;
    [GrammarRule("code_block")]
    private PseudoBFParser.code_block_return code_block()
    {

        PseudoBFParser.code_block_return retval = new PseudoBFParser.code_block_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal27=null;
        IToken char_literal29=null;
        IToken char_literal30=null;
        PseudoBFParser.statement_return statement28 = default(PseudoBFParser.statement_return);

        object char_literal27_tree=null;
        object char_literal29_tree=null;
        object char_literal30_tree=null;
        RewriteRuleITokenStream stream_43=new RewriteRuleITokenStream(adaptor,"token 43");
        RewriteRuleITokenStream stream_42=new RewriteRuleITokenStream(adaptor,"token 42");
        RewriteRuleITokenStream stream_44=new RewriteRuleITokenStream(adaptor,"token 44");
        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
    	try { DebugEnterRule(GrammarFileName, "code_block");
    	DebugLocation(58, 55);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:59:2: ( '{' ( statement ';' )* '}' -> ^( BLOCK_IMAG ( statement )* ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:59:4: '{' ( statement ';' )* '}'
    		{
    		DebugLocation(59, 4);
    		char_literal27=(IToken)Match(input,42,Follow._42_in_code_block328);  
    		stream_42.Add(char_literal27);

    		DebugLocation(59, 8);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:59:8: ( statement ';' )*
    		try { DebugEnterSubRule(7);
    		while (true)
    		{
    			int alt7=2;
    			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    			int LA7_0 = input.LA(1);

    			if ((LA7_0==ID||LA7_0==IF_KW||LA7_0==WHILE_KW||(LA7_0>=RETURN_KW && LA7_0<=PRINT_KW)))
    			{
    				alt7=1;
    			}


    			} finally { DebugExitDecision(7); }
    			switch ( alt7 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:59:9: statement ';'
    				{
    				DebugLocation(59, 9);
    				PushFollow(Follow._statement_in_code_block331);
    				statement28=statement();
    				PopFollow();

    				stream_statement.Add(statement28.Tree);
    				DebugLocation(59, 19);
    				char_literal29=(IToken)Match(input,43,Follow._43_in_code_block333);  
    				stream_43.Add(char_literal29);


    				}
    				break;

    			default:
    				goto loop7;
    			}
    		}

    		loop7:
    			;

    		} finally { DebugExitSubRule(7); }

    		DebugLocation(59, 25);
    		char_literal30=(IToken)Match(input,44,Follow._44_in_code_block337);  
    		stream_44.Add(char_literal30);



    		{
    		// AST REWRITE
    		// elements: statement
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 59:29: -> ^( BLOCK_IMAG ( statement )* )
    		{
    			DebugLocation(59, 32);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:59:32: ^( BLOCK_IMAG ( statement )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(59, 34);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK_IMAG, "BLOCK_IMAG"), root_1);

    			DebugLocation(59, 45);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:59:45: ( statement )*
    			while ( stream_statement.HasNext )
    			{
    				DebugLocation(59, 45);
    				adaptor.AddChild(root_1, stream_statement.NextTree());

    			}
    			stream_statement.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(59, 55);
    	} finally { DebugExitRule(GrammarFileName, "code_block"); }
    	return retval;

    }
    // $ANTLR end "code_block"

    public class statement_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_statement() {}
    protected virtual void Leave_statement() {}

    // $ANTLR start "statement"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:61:1: statement : ( assignment | return_value | call | printcall | if_ | while_ );
    [GrammarRule("statement")]
    private PseudoBFParser.statement_return statement()
    {

        PseudoBFParser.statement_return retval = new PseudoBFParser.statement_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        PseudoBFParser.assignment_return assignment31 = default(PseudoBFParser.assignment_return);
        PseudoBFParser.return_value_return return_value32 = default(PseudoBFParser.return_value_return);
        PseudoBFParser.call_return call33 = default(PseudoBFParser.call_return);
        PseudoBFParser.printcall_return printcall34 = default(PseudoBFParser.printcall_return);
        PseudoBFParser.if__return if_35 = default(PseudoBFParser.if__return);
        PseudoBFParser.while__return while_36 = default(PseudoBFParser.while__return);


    	try { DebugEnterRule(GrammarFileName, "statement");
    	DebugLocation(61, 9);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:62:2: ( assignment | return_value | call | printcall | if_ | while_ )
    		int alt8=6;
    		try { DebugEnterDecision(8, decisionCanBacktrack[8]);
    		switch (input.LA(1))
    		{
    		case ID:
    			{
    			int LA8_1 = input.LA(2);

    			if ((LA8_1==45))
    			{
    				alt8=1;
    			}
    			else if ((LA8_1==38))
    			{
    				alt8=3;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 8, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case RETURN_KW:
    			{
    			alt8=2;
    			}
    			break;
    		case PRINT_KW:
    			{
    			alt8=4;
    			}
    			break;
    		case IF_KW:
    			{
    			alt8=5;
    			}
    			break;
    		case WHILE_KW:
    			{
    			alt8=6;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(8); }
    		switch (alt8)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:62:4: assignment
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(62, 4);
    			PushFollow(Follow._assignment_in_statement355);
    			assignment31=assignment();
    			PopFollow();

    			adaptor.AddChild(root_0, assignment31.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:63:4: return_value
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(63, 4);
    			PushFollow(Follow._return_value_in_statement360);
    			return_value32=return_value();
    			PopFollow();

    			adaptor.AddChild(root_0, return_value32.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:64:4: call
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(64, 4);
    			PushFollow(Follow._call_in_statement365);
    			call33=call();
    			PopFollow();

    			adaptor.AddChild(root_0, call33.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:65:4: printcall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(65, 4);
    			PushFollow(Follow._printcall_in_statement370);
    			printcall34=printcall();
    			PopFollow();

    			adaptor.AddChild(root_0, printcall34.Tree);

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:66:4: if_
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(66, 4);
    			PushFollow(Follow._if__in_statement375);
    			if_35=if_();
    			PopFollow();

    			adaptor.AddChild(root_0, if_35.Tree);

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:67:4: while_
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(67, 4);
    			PushFollow(Follow._while__in_statement380);
    			while_36=while_();
    			PopFollow();

    			adaptor.AddChild(root_0, while_36.Tree);

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(67, 9);
    	} finally { DebugExitRule(GrammarFileName, "statement"); }
    	return retval;

    }
    // $ANTLR end "statement"

    public class if__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_if_() {}
    protected virtual void Leave_if_() {}

    // $ANTLR start "if_"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:69:1: if_ : IF_KW '(' expression ')' code_block ( else_ )? -> ^( IF_IMAG expression code_block ( else_ )? ) ;
    [GrammarRule("if_")]
    private PseudoBFParser.if__return if_()
    {

        PseudoBFParser.if__return retval = new PseudoBFParser.if__return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken IF_KW37=null;
        IToken char_literal38=null;
        IToken char_literal40=null;
        PseudoBFParser.expression_return expression39 = default(PseudoBFParser.expression_return);
        PseudoBFParser.code_block_return code_block41 = default(PseudoBFParser.code_block_return);
        PseudoBFParser.else__return else_42 = default(PseudoBFParser.else__return);

        object IF_KW37_tree=null;
        object char_literal38_tree=null;
        object char_literal40_tree=null;
        RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
        RewriteRuleITokenStream stream_IF_KW=new RewriteRuleITokenStream(adaptor,"token IF_KW");
        RewriteRuleITokenStream stream_38=new RewriteRuleITokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_else_=new RewriteRuleSubtreeStream(adaptor,"rule else_");
        RewriteRuleSubtreeStream stream_code_block=new RewriteRuleSubtreeStream(adaptor,"rule code_block");
    	try { DebugEnterRule(GrammarFileName, "if_");
    	DebugLocation(69, 91);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:69:5: ( IF_KW '(' expression ')' code_block ( else_ )? -> ^( IF_IMAG expression code_block ( else_ )? ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:69:7: IF_KW '(' expression ')' code_block ( else_ )?
    		{
    		DebugLocation(69, 7);
    		IF_KW37=(IToken)Match(input,IF_KW,Follow._IF_KW_in_if_389);  
    		stream_IF_KW.Add(IF_KW37);

    		DebugLocation(69, 13);
    		char_literal38=(IToken)Match(input,38,Follow._38_in_if_391);  
    		stream_38.Add(char_literal38);

    		DebugLocation(69, 17);
    		PushFollow(Follow._expression_in_if_393);
    		expression39=expression();
    		PopFollow();

    		stream_expression.Add(expression39.Tree);
    		DebugLocation(69, 28);
    		char_literal40=(IToken)Match(input,39,Follow._39_in_if_395);  
    		stream_39.Add(char_literal40);

    		DebugLocation(69, 32);
    		PushFollow(Follow._code_block_in_if_397);
    		code_block41=code_block();
    		PopFollow();

    		stream_code_block.Add(code_block41.Tree);
    		DebugLocation(69, 43);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:69:43: ( else_ )?
    		int alt9=2;
    		try { DebugEnterSubRule(9);
    		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    		int LA9_0 = input.LA(1);

    		if ((LA9_0==ELSE_KW))
    		{
    			alt9=1;
    		}
    		} finally { DebugExitDecision(9); }
    		switch (alt9)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:69:43: else_
    			{
    			DebugLocation(69, 43);
    			PushFollow(Follow._else__in_if_399);
    			else_42=else_();
    			PopFollow();

    			stream_else_.Add(else_42.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(9); }



    		{
    		// AST REWRITE
    		// elements: code_block, else_, expression
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 69:50: -> ^( IF_IMAG expression code_block ( else_ )? )
    		{
    			DebugLocation(69, 53);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:69:53: ^( IF_IMAG expression code_block ( else_ )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(69, 55);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF_IMAG, "IF_IMAG"), root_1);

    			DebugLocation(69, 63);
    			adaptor.AddChild(root_1, stream_expression.NextTree());
    			DebugLocation(69, 74);
    			adaptor.AddChild(root_1, stream_code_block.NextTree());
    			DebugLocation(69, 85);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:69:85: ( else_ )?
    			if ( stream_else_.HasNext )
    			{
    				DebugLocation(69, 85);
    				adaptor.AddChild(root_1, stream_else_.NextTree());

    			}
    			stream_else_.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(69, 91);
    	} finally { DebugExitRule(GrammarFileName, "if_"); }
    	return retval;

    }
    // $ANTLR end "if_"

    public class else__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_else_() {}
    protected virtual void Leave_else_() {}

    // $ANTLR start "else_"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:71:1: else_ : ELSE_KW code_block -> ^( ELSE_IMAG code_block ) ;
    [GrammarRule("else_")]
    private PseudoBFParser.else__return else_()
    {

        PseudoBFParser.else__return retval = new PseudoBFParser.else__return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ELSE_KW43=null;
        PseudoBFParser.code_block_return code_block44 = default(PseudoBFParser.code_block_return);

        object ELSE_KW43_tree=null;
        RewriteRuleITokenStream stream_ELSE_KW=new RewriteRuleITokenStream(adaptor,"token ELSE_KW");
        RewriteRuleSubtreeStream stream_code_block=new RewriteRuleSubtreeStream(adaptor,"rule code_block");
    	try { DebugEnterRule(GrammarFileName, "else_");
    	DebugLocation(71, 54);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:71:8: ( ELSE_KW code_block -> ^( ELSE_IMAG code_block ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:71:10: ELSE_KW code_block
    		{
    		DebugLocation(71, 10);
    		ELSE_KW43=(IToken)Match(input,ELSE_KW,Follow._ELSE_KW_in_else_422);  
    		stream_ELSE_KW.Add(ELSE_KW43);

    		DebugLocation(71, 18);
    		PushFollow(Follow._code_block_in_else_424);
    		code_block44=code_block();
    		PopFollow();

    		stream_code_block.Add(code_block44.Tree);


    		{
    		// AST REWRITE
    		// elements: code_block
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 71:29: -> ^( ELSE_IMAG code_block )
    		{
    			DebugLocation(71, 32);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:71:32: ^( ELSE_IMAG code_block )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(71, 34);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ELSE_IMAG, "ELSE_IMAG"), root_1);

    			DebugLocation(71, 44);
    			adaptor.AddChild(root_1, stream_code_block.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(71, 54);
    	} finally { DebugExitRule(GrammarFileName, "else_"); }
    	return retval;

    }
    // $ANTLR end "else_"

    public class while__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_while_() {}
    protected virtual void Leave_while_() {}

    // $ANTLR start "while_"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:73:1: while_ : WHILE_KW '(' expression ')' code_block -> ^( WHILE_IMAG expression code_block ) ;
    [GrammarRule("while_")]
    private PseudoBFParser.while__return while_()
    {

        PseudoBFParser.while__return retval = new PseudoBFParser.while__return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken WHILE_KW45=null;
        IToken char_literal46=null;
        IToken char_literal48=null;
        PseudoBFParser.expression_return expression47 = default(PseudoBFParser.expression_return);
        PseudoBFParser.code_block_return code_block49 = default(PseudoBFParser.code_block_return);

        object WHILE_KW45_tree=null;
        object char_literal46_tree=null;
        object char_literal48_tree=null;
        RewriteRuleITokenStream stream_WHILE_KW=new RewriteRuleITokenStream(adaptor,"token WHILE_KW");
        RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
        RewriteRuleITokenStream stream_38=new RewriteRuleITokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_code_block=new RewriteRuleSubtreeStream(adaptor,"rule code_block");
    	try { DebugEnterRule(GrammarFileName, "while_");
    	DebugLocation(73, 86);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:73:8: ( WHILE_KW '(' expression ')' code_block -> ^( WHILE_IMAG expression code_block ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:73:10: WHILE_KW '(' expression ')' code_block
    		{
    		DebugLocation(73, 10);
    		WHILE_KW45=(IToken)Match(input,WHILE_KW,Follow._WHILE_KW_in_while_440);  
    		stream_WHILE_KW.Add(WHILE_KW45);

    		DebugLocation(73, 19);
    		char_literal46=(IToken)Match(input,38,Follow._38_in_while_442);  
    		stream_38.Add(char_literal46);

    		DebugLocation(73, 23);
    		PushFollow(Follow._expression_in_while_444);
    		expression47=expression();
    		PopFollow();

    		stream_expression.Add(expression47.Tree);
    		DebugLocation(73, 34);
    		char_literal48=(IToken)Match(input,39,Follow._39_in_while_446);  
    		stream_39.Add(char_literal48);

    		DebugLocation(73, 38);
    		PushFollow(Follow._code_block_in_while_448);
    		code_block49=code_block();
    		PopFollow();

    		stream_code_block.Add(code_block49.Tree);


    		{
    		// AST REWRITE
    		// elements: code_block, expression
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 73:49: -> ^( WHILE_IMAG expression code_block )
    		{
    			DebugLocation(73, 52);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:73:52: ^( WHILE_IMAG expression code_block )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(73, 54);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(WHILE_IMAG, "WHILE_IMAG"), root_1);

    			DebugLocation(73, 65);
    			adaptor.AddChild(root_1, stream_expression.NextTree());
    			DebugLocation(73, 76);
    			adaptor.AddChild(root_1, stream_code_block.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(73, 86);
    	} finally { DebugExitRule(GrammarFileName, "while_"); }
    	return retval;

    }
    // $ANTLR end "while_"

    public class assignment_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_assignment() {}
    protected virtual void Leave_assignment() {}

    // $ANTLR start "assignment"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:75:1: assignment : ID '=' expression -> ^( ASSIGN_IMAG ID expression ) ;
    [GrammarRule("assignment")]
    private PseudoBFParser.assignment_return assignment()
    {

        PseudoBFParser.assignment_return retval = new PseudoBFParser.assignment_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID50=null;
        IToken char_literal51=null;
        PseudoBFParser.expression_return expression52 = default(PseudoBFParser.expression_return);

        object ID50_tree=null;
        object char_literal51_tree=null;
        RewriteRuleITokenStream stream_45=new RewriteRuleITokenStream(adaptor,"token 45");
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
    	try { DebugEnterRule(GrammarFileName, "assignment");
    	DebugLocation(75, 52);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:76:2: ( ID '=' expression -> ^( ASSIGN_IMAG ID expression ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:76:4: ID '=' expression
    		{
    		DebugLocation(76, 4);
    		ID50=(IToken)Match(input,ID,Follow._ID_in_assignment468);  
    		stream_ID.Add(ID50);

    		DebugLocation(76, 7);
    		char_literal51=(IToken)Match(input,45,Follow._45_in_assignment470);  
    		stream_45.Add(char_literal51);

    		DebugLocation(76, 11);
    		PushFollow(Follow._expression_in_assignment472);
    		expression52=expression();
    		PopFollow();

    		stream_expression.Add(expression52.Tree);


    		{
    		// AST REWRITE
    		// elements: expression, ID
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 76:22: -> ^( ASSIGN_IMAG ID expression )
    		{
    			DebugLocation(76, 25);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:76:25: ^( ASSIGN_IMAG ID expression )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(76, 27);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN_IMAG, "ASSIGN_IMAG"), root_1);

    			DebugLocation(76, 39);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(76, 42);
    			adaptor.AddChild(root_1, stream_expression.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(76, 52);
    	} finally { DebugExitRule(GrammarFileName, "assignment"); }
    	return retval;

    }
    // $ANTLR end "assignment"

    public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_expression() {}
    protected virtual void Leave_expression() {}

    // $ANTLR start "expression"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:78:1: expression : ( value OPERATOR value -> ^( OPERATOR_CALL_IMAG OPERATOR value value ) | call | value );
    [GrammarRule("expression")]
    private PseudoBFParser.expression_return expression()
    {

        PseudoBFParser.expression_return retval = new PseudoBFParser.expression_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OPERATOR54=null;
        PseudoBFParser.value_return value53 = default(PseudoBFParser.value_return);
        PseudoBFParser.value_return value55 = default(PseudoBFParser.value_return);
        PseudoBFParser.call_return call56 = default(PseudoBFParser.call_return);
        PseudoBFParser.value_return value57 = default(PseudoBFParser.value_return);

        object OPERATOR54_tree=null;
        RewriteRuleITokenStream stream_OPERATOR=new RewriteRuleITokenStream(adaptor,"token OPERATOR");
        RewriteRuleSubtreeStream stream_value=new RewriteRuleSubtreeStream(adaptor,"rule value");
    	try { DebugEnterRule(GrammarFileName, "expression");
    	DebugLocation(78, 8);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:79:2: ( value OPERATOR value -> ^( OPERATOR_CALL_IMAG OPERATOR value value ) | call | value )
    		int alt10=3;
    		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    		int LA10_0 = input.LA(1);

    		if ((LA10_0==NUMBER))
    		{
    			int LA10_1 = input.LA(2);

    			if ((LA10_1==OPERATOR))
    			{
    				alt10=1;
    			}
    			else if ((LA10_1==39||LA10_1==43))
    			{
    				alt10=3;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 10, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else if ((LA10_0==ID))
    		{
    			switch (input.LA(2))
    			{
    			case OPERATOR:
    				{
    				alt10=1;
    				}
    				break;
    			case 38:
    				{
    				alt10=2;
    				}
    				break;
    			case 39:
    			case 43:
    				{
    				alt10=3;
    				}
    				break;
    			default:
    				{
    					NoViableAltException nvae = new NoViableAltException("", 10, 2, input);

    					DebugRecognitionException(nvae);
    					throw nvae;
    				}
    			}

    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(10); }
    		switch (alt10)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:79:4: value OPERATOR value
    			{
    			DebugLocation(79, 4);
    			PushFollow(Follow._value_in_expression492);
    			value53=value();
    			PopFollow();

    			stream_value.Add(value53.Tree);
    			DebugLocation(79, 10);
    			OPERATOR54=(IToken)Match(input,OPERATOR,Follow._OPERATOR_in_expression494);  
    			stream_OPERATOR.Add(OPERATOR54);

    			DebugLocation(79, 19);
    			PushFollow(Follow._value_in_expression496);
    			value55=value();
    			PopFollow();

    			stream_value.Add(value55.Tree);


    			{
    			// AST REWRITE
    			// elements: OPERATOR, value, value
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 79:25: -> ^( OPERATOR_CALL_IMAG OPERATOR value value )
    			{
    				DebugLocation(79, 28);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:79:28: ^( OPERATOR_CALL_IMAG OPERATOR value value )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(79, 30);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OPERATOR_CALL_IMAG, "OPERATOR_CALL_IMAG"), root_1);

    				DebugLocation(79, 49);
    				adaptor.AddChild(root_1, stream_OPERATOR.NextNode());
    				DebugLocation(79, 58);
    				adaptor.AddChild(root_1, stream_value.NextTree());
    				DebugLocation(79, 64);
    				adaptor.AddChild(root_1, stream_value.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:80:4: call
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(80, 4);
    			PushFollow(Follow._call_in_expression513);
    			call56=call();
    			PopFollow();

    			adaptor.AddChild(root_0, call56.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:81:4: value
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(81, 4);
    			PushFollow(Follow._value_in_expression518);
    			value57=value();
    			PopFollow();

    			adaptor.AddChild(root_0, value57.Tree);

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(81, 8);
    	} finally { DebugExitRule(GrammarFileName, "expression"); }
    	return retval;

    }
    // $ANTLR end "expression"

    public class value_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_value() {}
    protected virtual void Leave_value() {}

    // $ANTLR start "value"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:83:1: value : ( NUMBER -> ^( NUMBER_IMAG NUMBER ) | ID -> ^( VARIABLE_IMAG ID ) );
    [GrammarRule("value")]
    private PseudoBFParser.value_return value()
    {

        PseudoBFParser.value_return retval = new PseudoBFParser.value_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken NUMBER58=null;
        IToken ID59=null;

        object NUMBER58_tree=null;
        object ID59_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_NUMBER=new RewriteRuleITokenStream(adaptor,"token NUMBER");

    	try { DebugEnterRule(GrammarFileName, "value");
    	DebugLocation(83, 28);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:83:7: ( NUMBER -> ^( NUMBER_IMAG NUMBER ) | ID -> ^( VARIABLE_IMAG ID ) )
    		int alt11=2;
    		try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    		int LA11_0 = input.LA(1);

    		if ((LA11_0==NUMBER))
    		{
    			alt11=1;
    		}
    		else if ((LA11_0==ID))
    		{
    			alt11=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(11); }
    		switch (alt11)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:83:9: NUMBER
    			{
    			DebugLocation(83, 9);
    			NUMBER58=(IToken)Match(input,NUMBER,Follow._NUMBER_in_value527);  
    			stream_NUMBER.Add(NUMBER58);



    			{
    			// AST REWRITE
    			// elements: NUMBER
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 83:16: -> ^( NUMBER_IMAG NUMBER )
    			{
    				DebugLocation(83, 19);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:83:19: ^( NUMBER_IMAG NUMBER )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(83, 21);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NUMBER_IMAG, "NUMBER_IMAG"), root_1);

    				DebugLocation(83, 33);
    				adaptor.AddChild(root_1, stream_NUMBER.NextNode());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:84:4: ID
    			{
    			DebugLocation(84, 4);
    			ID59=(IToken)Match(input,ID,Follow._ID_in_value540);  
    			stream_ID.Add(ID59);



    			{
    			// AST REWRITE
    			// elements: ID
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 84:7: -> ^( VARIABLE_IMAG ID )
    			{
    				DebugLocation(84, 10);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:84:10: ^( VARIABLE_IMAG ID )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(84, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARIABLE_IMAG, "VARIABLE_IMAG"), root_1);

    				DebugLocation(84, 26);
    				adaptor.AddChild(root_1, stream_ID.NextNode());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(84, 28);
    	} finally { DebugExitRule(GrammarFileName, "value"); }
    	return retval;

    }
    // $ANTLR end "value"

    public class return_value_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_return_value() {}
    protected virtual void Leave_return_value() {}

    // $ANTLR start "return_value"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:86:1: return_value : RETURN_KW value -> ^( RETURN_IMAG value ) ;
    [GrammarRule("return_value")]
    private PseudoBFParser.return_value_return return_value()
    {

        PseudoBFParser.return_value_return retval = new PseudoBFParser.return_value_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken RETURN_KW60=null;
        PseudoBFParser.value_return value61 = default(PseudoBFParser.value_return);

        object RETURN_KW60_tree=null;
        RewriteRuleITokenStream stream_RETURN_KW=new RewriteRuleITokenStream(adaptor,"token RETURN_KW");
        RewriteRuleSubtreeStream stream_value=new RewriteRuleSubtreeStream(adaptor,"rule value");
    	try { DebugEnterRule(GrammarFileName, "return_value");
    	DebugLocation(86, 42);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:87:2: ( RETURN_KW value -> ^( RETURN_IMAG value ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:87:4: RETURN_KW value
    		{
    		DebugLocation(87, 4);
    		RETURN_KW60=(IToken)Match(input,RETURN_KW,Follow._RETURN_KW_in_return_value558);  
    		stream_RETURN_KW.Add(RETURN_KW60);

    		DebugLocation(87, 14);
    		PushFollow(Follow._value_in_return_value560);
    		value61=value();
    		PopFollow();

    		stream_value.Add(value61.Tree);


    		{
    		// AST REWRITE
    		// elements: value
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 87:20: -> ^( RETURN_IMAG value )
    		{
    			DebugLocation(87, 23);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:87:23: ^( RETURN_IMAG value )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(87, 25);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN_IMAG, "RETURN_IMAG"), root_1);

    			DebugLocation(87, 37);
    			adaptor.AddChild(root_1, stream_value.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(87, 42);
    	} finally { DebugExitRule(GrammarFileName, "return_value"); }
    	return retval;

    }
    // $ANTLR end "return_value"

    public class call_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_call() {}
    protected virtual void Leave_call() {}

    // $ANTLR start "call"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:89:1: call : ID value_list -> ^( CALL_IMAG ID value_list ) ;
    [GrammarRule("call")]
    private PseudoBFParser.call_return call()
    {

        PseudoBFParser.call_return retval = new PseudoBFParser.call_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID62=null;
        PseudoBFParser.value_list_return value_list63 = default(PseudoBFParser.value_list_return);

        object ID62_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_value_list=new RewriteRuleSubtreeStream(adaptor,"rule value_list");
    	try { DebugEnterRule(GrammarFileName, "call");
    	DebugLocation(89, 50);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:89:6: ( ID value_list -> ^( CALL_IMAG ID value_list ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:89:8: ID value_list
    		{
    		DebugLocation(89, 8);
    		ID62=(IToken)Match(input,ID,Follow._ID_in_call576);  
    		stream_ID.Add(ID62);

    		DebugLocation(89, 11);
    		PushFollow(Follow._value_list_in_call578);
    		value_list63=value_list();
    		PopFollow();

    		stream_value_list.Add(value_list63.Tree);


    		{
    		// AST REWRITE
    		// elements: value_list, ID
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 89:22: -> ^( CALL_IMAG ID value_list )
    		{
    			DebugLocation(89, 25);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:89:25: ^( CALL_IMAG ID value_list )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(89, 27);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL_IMAG, "CALL_IMAG"), root_1);

    			DebugLocation(89, 37);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(89, 40);
    			adaptor.AddChild(root_1, stream_value_list.NextTree());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(89, 50);
    	} finally { DebugExitRule(GrammarFileName, "call"); }
    	return retval;

    }
    // $ANTLR end "call"

    public class printcall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_printcall() {}
    protected virtual void Leave_printcall() {}

    // $ANTLR start "printcall"
    // D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:91:1: printcall : PRINT_KW '(' STRING ')' -> ^( PRINT_IMAG STRING ) ;
    [GrammarRule("printcall")]
    private PseudoBFParser.printcall_return printcall()
    {

        PseudoBFParser.printcall_return retval = new PseudoBFParser.printcall_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PRINT_KW64=null;
        IToken char_literal65=null;
        IToken STRING66=null;
        IToken char_literal67=null;

        object PRINT_KW64_tree=null;
        object char_literal65_tree=null;
        object STRING66_tree=null;
        object char_literal67_tree=null;
        RewriteRuleITokenStream stream_PRINT_KW=new RewriteRuleITokenStream(adaptor,"token PRINT_KW");
        RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
        RewriteRuleITokenStream stream_STRING=new RewriteRuleITokenStream(adaptor,"token STRING");
        RewriteRuleITokenStream stream_38=new RewriteRuleITokenStream(adaptor,"token 38");

    	try { DebugEnterRule(GrammarFileName, "printcall");
    	DebugLocation(91, 50);
    	try
    	{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:92:2: ( PRINT_KW '(' STRING ')' -> ^( PRINT_IMAG STRING ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:92:4: PRINT_KW '(' STRING ')'
    		{
    		DebugLocation(92, 4);
    		PRINT_KW64=(IToken)Match(input,PRINT_KW,Follow._PRINT_KW_in_printcall597);  
    		stream_PRINT_KW.Add(PRINT_KW64);

    		DebugLocation(92, 13);
    		char_literal65=(IToken)Match(input,38,Follow._38_in_printcall599);  
    		stream_38.Add(char_literal65);

    		DebugLocation(92, 17);
    		STRING66=(IToken)Match(input,STRING,Follow._STRING_in_printcall601);  
    		stream_STRING.Add(STRING66);

    		DebugLocation(92, 24);
    		char_literal67=(IToken)Match(input,39,Follow._39_in_printcall603);  
    		stream_39.Add(char_literal67);



    		{
    		// AST REWRITE
    		// elements: STRING
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 92:28: -> ^( PRINT_IMAG STRING )
    		{
    			DebugLocation(92, 31);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:92:31: ^( PRINT_IMAG STRING )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(92, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PRINT_IMAG, "PRINT_IMAG"), root_1);

    			DebugLocation(92, 44);
    			adaptor.AddChild(root_1, stream_STRING.NextNode());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(92, 50);
    	} finally { DebugExitRule(GrammarFileName, "printcall"); }
    	return retval;

    }
    // $ANTLR end "printcall"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _subroutines_in_program136 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_program138 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _subroutine_in_subroutines155 = new BitSet(new ulong[]{0x0000000000C00002UL});
		public static readonly BitSet _subroutine_type_in_subroutine165 = new BitSet(new ulong[]{0x0000000000200000UL});
		public static readonly BitSet _ID_in_subroutine167 = new BitSet(new ulong[]{0x0000004000000000UL});
		public static readonly BitSet _variable_list_in_subroutine169 = new BitSet(new ulong[]{0x0000060000000000UL});
		public static readonly BitSet _locals_def_in_subroutine171 = new BitSet(new ulong[]{0x0000060000000000UL});
		public static readonly BitSet _code_block_in_subroutine173 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_subroutine_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _38_in_variable_list213 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _39_in_variable_list215 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _38_in_variable_list226 = new BitSet(new ulong[]{0x0000000000200000UL});
		public static readonly BitSet _ID_in_variable_list228 = new BitSet(new ulong[]{0x0000018000000000UL});
		public static readonly BitSet _40_in_variable_list231 = new BitSet(new ulong[]{0x0000000000200000UL});
		public static readonly BitSet _ID_in_variable_list233 = new BitSet(new ulong[]{0x0000018000000000UL});
		public static readonly BitSet _39_in_variable_list237 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _38_in_value_list255 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _39_in_value_list257 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _38_in_value_list268 = new BitSet(new ulong[]{0x0000000020200000UL});
		public static readonly BitSet _value_in_value_list270 = new BitSet(new ulong[]{0x0000018000000000UL});
		public static readonly BitSet _40_in_value_list273 = new BitSet(new ulong[]{0x0000000020200000UL});
		public static readonly BitSet _value_in_value_list275 = new BitSet(new ulong[]{0x0000018000000000UL});
		public static readonly BitSet _39_in_value_list279 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _41_in_locals_def297 = new BitSet(new ulong[]{0x0000000001000000UL});
		public static readonly BitSet _LOCALS_KW_in_locals_def299 = new BitSet(new ulong[]{0x0000004000000000UL});
		public static readonly BitSet _variable_list_in_locals_def301 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _42_in_code_block328 = new BitSet(new ulong[]{0x00001000CA200000UL});
		public static readonly BitSet _statement_in_code_block331 = new BitSet(new ulong[]{0x0000080000000000UL});
		public static readonly BitSet _43_in_code_block333 = new BitSet(new ulong[]{0x00001000CA200000UL});
		public static readonly BitSet _44_in_code_block337 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assignment_in_statement355 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _return_value_in_statement360 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _call_in_statement365 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _printcall_in_statement370 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _if__in_statement375 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _while__in_statement380 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_KW_in_if_389 = new BitSet(new ulong[]{0x0000004000000000UL});
		public static readonly BitSet _38_in_if_391 = new BitSet(new ulong[]{0x0000000020200000UL});
		public static readonly BitSet _expression_in_if_393 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _39_in_if_395 = new BitSet(new ulong[]{0x0000060000000000UL});
		public static readonly BitSet _code_block_in_if_397 = new BitSet(new ulong[]{0x0000000004000002UL});
		public static readonly BitSet _else__in_if_399 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ELSE_KW_in_else_422 = new BitSet(new ulong[]{0x0000060000000000UL});
		public static readonly BitSet _code_block_in_else_424 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_KW_in_while_440 = new BitSet(new ulong[]{0x0000004000000000UL});
		public static readonly BitSet _38_in_while_442 = new BitSet(new ulong[]{0x0000000020200000UL});
		public static readonly BitSet _expression_in_while_444 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _39_in_while_446 = new BitSet(new ulong[]{0x0000060000000000UL});
		public static readonly BitSet _code_block_in_while_448 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_assignment468 = new BitSet(new ulong[]{0x0000200000000000UL});
		public static readonly BitSet _45_in_assignment470 = new BitSet(new ulong[]{0x0000000020200000UL});
		public static readonly BitSet _expression_in_assignment472 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _value_in_expression492 = new BitSet(new ulong[]{0x0000000010000000UL});
		public static readonly BitSet _OPERATOR_in_expression494 = new BitSet(new ulong[]{0x0000000020200000UL});
		public static readonly BitSet _value_in_expression496 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _call_in_expression513 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _value_in_expression518 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NUMBER_in_value527 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_value540 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _RETURN_KW_in_return_value558 = new BitSet(new ulong[]{0x0000000020200000UL});
		public static readonly BitSet _value_in_return_value560 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_call576 = new BitSet(new ulong[]{0x0000004000000000UL});
		public static readonly BitSet _value_list_in_call578 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PRINT_KW_in_printcall597 = new BitSet(new ulong[]{0x0000004000000000UL});
		public static readonly BitSet _38_in_printcall599 = new BitSet(new ulong[]{0x0000000100000000UL});
		public static readonly BitSet _STRING_in_printcall601 = new BitSet(new ulong[]{0x0000008000000000UL});
		public static readonly BitSet _39_in_printcall603 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}