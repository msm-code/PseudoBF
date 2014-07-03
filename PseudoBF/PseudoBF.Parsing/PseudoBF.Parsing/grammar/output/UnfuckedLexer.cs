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

namespace  PseudoBF.Parsing 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class PseudoBFLexer : Antlr.Runtime.Lexer
{
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
	const int HIDDEN = Hidden;

    // delegates
    // delegators

	public PseudoBFLexer()
	{
		OnCreated();
	}

	public PseudoBFLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public PseudoBFLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];

 
	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    protected virtual void Enter_T__38() {}
    protected virtual void Leave_T__38() {}

    // $ANTLR start "T__38"
    [GrammarRule("T__38")]
    private void mT__38()
    {

    		try
    		{
    		int _type = T__38;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:10:7: ( '(' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:10:9: '('
    		{
    		DebugLocation(10, 9);
    		Match('('); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__38"

    protected virtual void Enter_T__39() {}
    protected virtual void Leave_T__39() {}

    // $ANTLR start "T__39"
    [GrammarRule("T__39")]
    private void mT__39()
    {

    		try
    		{
    		int _type = T__39;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:11:7: ( ')' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:11:9: ')'
    		{
    		DebugLocation(11, 9);
    		Match(')'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__39"

    protected virtual void Enter_T__40() {}
    protected virtual void Leave_T__40() {}

    // $ANTLR start "T__40"
    [GrammarRule("T__40")]
    private void mT__40()
    {

    		try
    		{
    		int _type = T__40;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:12:7: ( ',' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:12:9: ','
    		{
    		DebugLocation(12, 9);
    		Match(','); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__40"

    protected virtual void Enter_T__41() {}
    protected virtual void Leave_T__41() {}

    // $ANTLR start "T__41"
    [GrammarRule("T__41")]
    private void mT__41()
    {

    		try
    		{
    		int _type = T__41;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:13:7: ( ':' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:13:9: ':'
    		{
    		DebugLocation(13, 9);
    		Match(':'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__41"

    protected virtual void Enter_T__42() {}
    protected virtual void Leave_T__42() {}

    // $ANTLR start "T__42"
    [GrammarRule("T__42")]
    private void mT__42()
    {

    		try
    		{
    		int _type = T__42;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:14:7: ( '{' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:14:9: '{'
    		{
    		DebugLocation(14, 9);
    		Match('{'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__42"

    protected virtual void Enter_T__43() {}
    protected virtual void Leave_T__43() {}

    // $ANTLR start "T__43"
    [GrammarRule("T__43")]
    private void mT__43()
    {

    		try
    		{
    		int _type = T__43;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:15:7: ( ';' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:15:9: ';'
    		{
    		DebugLocation(15, 9);
    		Match(';'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__43"

    protected virtual void Enter_T__44() {}
    protected virtual void Leave_T__44() {}

    // $ANTLR start "T__44"
    [GrammarRule("T__44")]
    private void mT__44()
    {

    		try
    		{
    		int _type = T__44;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:16:7: ( '}' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:16:9: '}'
    		{
    		DebugLocation(16, 9);
    		Match('}'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__44"

    protected virtual void Enter_T__45() {}
    protected virtual void Leave_T__45() {}

    // $ANTLR start "T__45"
    [GrammarRule("T__45")]
    private void mT__45()
    {

    		try
    		{
    		int _type = T__45;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:17:7: ( '=' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:17:9: '='
    		{
    		DebugLocation(17, 9);
    		Match('='); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__45"

    protected virtual void Enter_PRINT_KW() {}
    protected virtual void Leave_PRINT_KW() {}

    // $ANTLR start "PRINT_KW"
    [GrammarRule("PRINT_KW")]
    private void mPRINT_KW()
    {

    		try
    		{
    		int _type = PRINT_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:95:9: ( 'print' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:95:11: 'print'
    		{
    		DebugLocation(95, 11);
    		Match("print"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "PRINT_KW"

    protected virtual void Enter_IF_KW() {}
    protected virtual void Leave_IF_KW() {}

    // $ANTLR start "IF_KW"
    [GrammarRule("IF_KW")]
    private void mIF_KW()
    {

    		try
    		{
    		int _type = IF_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:97:7: ( 'if' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:97:9: 'if'
    		{
    		DebugLocation(97, 9);
    		Match("if"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "IF_KW"

    protected virtual void Enter_RETURN_KW() {}
    protected virtual void Leave_RETURN_KW() {}

    // $ANTLR start "RETURN_KW"
    [GrammarRule("RETURN_KW")]
    private void mRETURN_KW()
    {

    		try
    		{
    		int _type = RETURN_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:100:2: ( 'return' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:100:4: 'return'
    		{
    		DebugLocation(100, 4);
    		Match("return"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "RETURN_KW"

    protected virtual void Enter_FUNCTION_KW() {}
    protected virtual void Leave_FUNCTION_KW() {}

    // $ANTLR start "FUNCTION_KW"
    [GrammarRule("FUNCTION_KW")]
    private void mFUNCTION_KW()
    {

    		try
    		{
    		int _type = FUNCTION_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:103:2: ( 'function' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:103:4: 'function'
    		{
    		DebugLocation(103, 4);
    		Match("function"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "FUNCTION_KW"

    protected virtual void Enter_PROCEDURE_KW() {}
    protected virtual void Leave_PROCEDURE_KW() {}

    // $ANTLR start "PROCEDURE_KW"
    [GrammarRule("PROCEDURE_KW")]
    private void mPROCEDURE_KW()
    {

    		try
    		{
    		int _type = PROCEDURE_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:106:2: ( 'procedure' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:106:4: 'procedure'
    		{
    		DebugLocation(106, 4);
    		Match("procedure"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "PROCEDURE_KW"

    protected virtual void Enter_LOCALS_KW() {}
    protected virtual void Leave_LOCALS_KW() {}

    // $ANTLR start "LOCALS_KW"
    [GrammarRule("LOCALS_KW")]
    private void mLOCALS_KW()
    {

    		try
    		{
    		int _type = LOCALS_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:109:2: ( 'locals' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:109:4: 'locals'
    		{
    		DebugLocation(109, 4);
    		Match("locals"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LOCALS_KW"

    protected virtual void Enter_ELSE_KW() {}
    protected virtual void Leave_ELSE_KW() {}

    // $ANTLR start "ELSE_KW"
    [GrammarRule("ELSE_KW")]
    private void mELSE_KW()
    {

    		try
    		{
    		int _type = ELSE_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:111:9: ( 'else' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:111:11: 'else'
    		{
    		DebugLocation(111, 11);
    		Match("else"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ELSE_KW"

    protected virtual void Enter_WHILE_KW() {}
    protected virtual void Leave_WHILE_KW() {}

    // $ANTLR start "WHILE_KW"
    [GrammarRule("WHILE_KW")]
    private void mWHILE_KW()
    {

    		try
    		{
    		int _type = WHILE_KW;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:113:9: ( 'while' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:113:11: 'while'
    		{
    		DebugLocation(113, 11);
    		Match("while"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "WHILE_KW"

    protected virtual void Enter_OPERATOR() {}
    protected virtual void Leave_OPERATOR() {}

    // $ANTLR start "OPERATOR"
    [GrammarRule("OPERATOR")]
    private void mOPERATOR()
    {

    		try
    		{
    		int _type = OPERATOR;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:9: ( '+' | '-' | '*' | '/' | '^' | '<' | '>' | '==' | '!=' | '<=' | '>=' )
    		int alt1=11;
    		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    		try
    		{
    			alt1 = dfa1.Predict(input);
    		}
    		catch (NoViableAltException nvae)
    		{
    			DebugRecognitionException(nvae);
    			throw;
    		}
    		} finally { DebugExitDecision(1); }
    		switch (alt1)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:11: '+'
    			{
    			DebugLocation(115, 11);
    			Match('+'); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:17: '-'
    			{
    			DebugLocation(115, 17);
    			Match('-'); 

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:23: '*'
    			{
    			DebugLocation(115, 23);
    			Match('*'); 

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:29: '/'
    			{
    			DebugLocation(115, 29);
    			Match('/'); 

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:35: '^'
    			{
    			DebugLocation(115, 35);
    			Match('^'); 

    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:41: '<'
    			{
    			DebugLocation(115, 41);
    			Match('<'); 

    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:47: '>'
    			{
    			DebugLocation(115, 47);
    			Match('>'); 

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:53: '=='
    			{
    			DebugLocation(115, 53);
    			Match("=="); 


    			}
    			break;
    		case 9:
    			DebugEnterAlt(9);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:60: '!='
    			{
    			DebugLocation(115, 60);
    			Match("!="); 


    			}
    			break;
    		case 10:
    			DebugEnterAlt(10);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:67: '<='
    			{
    			DebugLocation(115, 67);
    			Match("<="); 


    			}
    			break;
    		case 11:
    			DebugEnterAlt(11);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:115:74: '>='
    			{
    			DebugLocation(115, 74);
    			Match(">="); 


    			}
    			break;

    		}
    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "OPERATOR"

    protected virtual void Enter_ID() {}
    protected virtual void Leave_ID() {}

    // $ANTLR start "ID"
    [GrammarRule("ID")]
    private void mID()
    {

    		try
    		{
    		int _type = ID;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:117:4: ( ( CHAR ) ( IDCHAR )* )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:117:6: ( CHAR ) ( IDCHAR )*
    		{
    		DebugLocation(117, 6);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:117:6: ( CHAR )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:117:7: CHAR
    		{
    		DebugLocation(117, 7);
    		mCHAR(); 

    		}

    		DebugLocation(117, 13);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:117:13: ( IDCHAR )*
    		try { DebugEnterSubRule(2);
    		while (true)
    		{
    			int alt2=2;
    			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    			int LA2_0 = input.LA(1);

    			if (((LA2_0>='0' && LA2_0<='9')||(LA2_0>='A' && LA2_0<='Z')||LA2_0=='_'||(LA2_0>='a' && LA2_0<='z')))
    			{
    				alt2=1;
    			}


    			} finally { DebugExitDecision(2); }
    			switch ( alt2 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:117:14: IDCHAR
    				{
    				DebugLocation(117, 14);
    				mIDCHAR(); 

    				}
    				break;

    			default:
    				goto loop2;
    			}
    		}

    		loop2:
    			;

    		} finally { DebugExitSubRule(2); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ID"

    protected virtual void Enter_NUMBER() {}
    protected virtual void Leave_NUMBER() {}

    // $ANTLR start "NUMBER"
    [GrammarRule("NUMBER")]
    private void mNUMBER()
    {

    		try
    		{
    		int _type = NUMBER;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:119:8: ( ( DIGIT )+ )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:119:10: ( DIGIT )+
    		{
    		DebugLocation(119, 10);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:119:10: ( DIGIT )+
    		int cnt3=0;
    		try { DebugEnterSubRule(3);
    		while (true)
    		{
    			int alt3=2;
    			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    			int LA3_0 = input.LA(1);

    			if (((LA3_0>='0' && LA3_0<='9')))
    			{
    				alt3=1;
    			}


    			} finally { DebugExitDecision(3); }
    			switch (alt3)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:119:10: DIGIT
    				{
    				DebugLocation(119, 10);
    				mDIGIT(); 

    				}
    				break;

    			default:
    				if (cnt3 >= 1)
    					goto loop3;

    				EarlyExitException eee3 = new EarlyExitException( 3, input );
    				DebugRecognitionException(eee3);
    				throw eee3;
    			}
    			cnt3++;
    		}
    		loop3:
    			;

    		} finally { DebugExitSubRule(3); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "NUMBER"

    protected virtual void Enter_STRING() {}
    protected virtual void Leave_STRING() {}

    // $ANTLR start "STRING"
    [GrammarRule("STRING")]
    private void mSTRING()
    {

    		try
    		{
    		int _type = STRING;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:121:9: ( ( '\"' (~ '\"' )* '\"' ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:121:11: ( '\"' (~ '\"' )* '\"' )
    		{
    		DebugLocation(121, 11);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:121:11: ( '\"' (~ '\"' )* '\"' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:121:12: '\"' (~ '\"' )* '\"'
    		{
    		DebugLocation(121, 12);
    		Match('\"'); 
    		DebugLocation(121, 16);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:121:16: (~ '\"' )*
    		try { DebugEnterSubRule(4);
    		while (true)
    		{
    			int alt4=2;
    			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    			int LA4_0 = input.LA(1);

    			if (((LA4_0>='\u0000' && LA4_0<='!')||(LA4_0>='#' && LA4_0<='\uFFFF')))
    			{
    				alt4=1;
    			}


    			} finally { DebugExitDecision(4); }
    			switch ( alt4 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:121:17: ~ '\"'
    				{
    				DebugLocation(121, 17);
    				if ((input.LA(1)>='\u0000' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='\uFFFF'))
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				goto loop4;
    			}
    		}

    		loop4:
    			;

    		} finally { DebugExitSubRule(4); }

    		DebugLocation(121, 24);
    		Match('\"'); 

    		}


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "STRING"

    protected virtual void Enter_IDCHAR() {}
    protected virtual void Leave_IDCHAR() {}

    // $ANTLR start "IDCHAR"
    [GrammarRule("IDCHAR")]
    private void mIDCHAR()
    {

    		try
    		{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:124:2: ( ( CHAR | DIGIT | UNDERSCORE ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:124:4: ( CHAR | DIGIT | UNDERSCORE )
    		{
    		DebugLocation(124, 4);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:124:4: ( CHAR | DIGIT | UNDERSCORE )
    		int alt5=3;
    		try { DebugEnterSubRule(5);
    		try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    		switch (input.LA(1))
    		{
    		case 'A':
    		case 'B':
    		case 'C':
    		case 'D':
    		case 'E':
    		case 'F':
    		case 'G':
    		case 'H':
    		case 'I':
    		case 'J':
    		case 'K':
    		case 'L':
    		case 'M':
    		case 'N':
    		case 'O':
    		case 'P':
    		case 'Q':
    		case 'R':
    		case 'S':
    		case 'T':
    		case 'U':
    		case 'V':
    		case 'W':
    		case 'X':
    		case 'Y':
    		case 'Z':
    		case 'a':
    		case 'b':
    		case 'c':
    		case 'd':
    		case 'e':
    		case 'f':
    		case 'g':
    		case 'h':
    		case 'i':
    		case 'j':
    		case 'k':
    		case 'l':
    		case 'm':
    		case 'n':
    		case 'o':
    		case 'p':
    		case 'q':
    		case 'r':
    		case 's':
    		case 't':
    		case 'u':
    		case 'v':
    		case 'w':
    		case 'x':
    		case 'y':
    		case 'z':
    			{
    			alt5=1;
    			}
    			break;
    		case '0':
    		case '1':
    		case '2':
    		case '3':
    		case '4':
    		case '5':
    		case '6':
    		case '7':
    		case '8':
    		case '9':
    			{
    			alt5=2;
    			}
    			break;
    		case '_':
    			{
    			alt5=3;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(5); }
    		switch (alt5)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:124:5: CHAR
    			{
    			DebugLocation(124, 5);
    			mCHAR(); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:124:12: DIGIT
    			{
    			DebugLocation(124, 12);
    			mDIGIT(); 

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:124:20: UNDERSCORE
    			{
    			DebugLocation(124, 20);
    			mUNDERSCORE(); 

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(5); }


    		}

    	}
    	finally
    	{
        }
    }
    // $ANTLR end "IDCHAR"

    protected virtual void Enter_UNDERSCORE() {}
    protected virtual void Leave_UNDERSCORE() {}

    // $ANTLR start "UNDERSCORE"
    [GrammarRule("UNDERSCORE")]
    private void mUNDERSCORE()
    {

    		try
    		{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:127:2: ( '_' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:127:4: '_'
    		{
    		DebugLocation(127, 4);
    		Match('_'); 

    		}

    	}
    	finally
    	{
        }
    }
    // $ANTLR end "UNDERSCORE"

    protected virtual void Enter_DIGIT() {}
    protected virtual void Leave_DIGIT() {}

    // $ANTLR start "DIGIT"
    [GrammarRule("DIGIT")]
    private void mDIGIT()
    {

    		try
    		{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:130:2: ( ( '0' .. '9' ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:130:4: ( '0' .. '9' )
    		{
    		DebugLocation(130, 4);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:130:4: ( '0' .. '9' )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:130:5: '0' .. '9'
    		{
    		DebugLocation(130, 5);
    		MatchRange('0','9'); 

    		}


    		}

    	}
    	finally
    	{
        }
    }
    // $ANTLR end "DIGIT"

    protected virtual void Enter_CHAR() {}
    protected virtual void Leave_CHAR() {}

    // $ANTLR start "CHAR"
    [GrammarRule("CHAR")]
    private void mCHAR()
    {

    		try
    		{
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:133:2: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:133:4: ( 'a' .. 'z' | 'A' .. 'Z' )
    		{
    		DebugLocation(133, 4);
    		if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
    		{
    			input.Consume();

    		}
    		else
    		{
    			MismatchedSetException mse = new MismatchedSetException(null,input);
    			DebugRecognitionException(mse);
    			Recover(mse);
    			throw mse;}


    		}

    	}
    	finally
    	{
        }
    }
    // $ANTLR end "CHAR"

    protected virtual void Enter_WHITESPACE() {}
    protected virtual void Leave_WHITESPACE() {}

    // $ANTLR start "WHITESPACE"
    [GrammarRule("WHITESPACE")]
    private void mWHITESPACE()
    {

    		try
    		{
    		int _type = WHITESPACE;
    		int _channel = DefaultTokenChannel;
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:135:12: ( ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+ )
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:135:14: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
    		{
    		DebugLocation(135, 14);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:135:14: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
    		int cnt6=0;
    		try { DebugEnterSubRule(6);
    		while (true)
    		{
    			int alt6=2;
    			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    			int LA6_0 = input.LA(1);

    			if (((LA6_0>='\t' && LA6_0<='\n')||(LA6_0>='\f' && LA6_0<='\r')||LA6_0==' '))
    			{
    				alt6=1;
    			}


    			} finally { DebugExitDecision(6); }
    			switch (alt6)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:
    				{
    				DebugLocation(135, 14);
    				if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				if (cnt6 >= 1)
    					goto loop6;

    				EarlyExitException eee6 = new EarlyExitException( 6, input );
    				DebugRecognitionException(eee6);
    				throw eee6;
    			}
    			cnt6++;
    		}
    		loop6:
    			;

    		} finally { DebugExitSubRule(6); }

    		DebugLocation(135, 55);
    		 _channel = HIDDEN; 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    public override void mTokens()
    {
    	// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:8: ( T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | PRINT_KW | IF_KW | RETURN_KW | FUNCTION_KW | PROCEDURE_KW | LOCALS_KW | ELSE_KW | WHILE_KW | OPERATOR | ID | NUMBER | STRING | WHITESPACE )
    	int alt7=21;
    	try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    	try
    	{
    		alt7 = dfa7.Predict(input);
    	}
    	catch (NoViableAltException nvae)
    	{
    		DebugRecognitionException(nvae);
    		throw;
    	}
    	} finally { DebugExitDecision(7); }
    	switch (alt7)
    	{
    	case 1:
    		DebugEnterAlt(1);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:10: T__38
    		{
    		DebugLocation(1, 10);
    		mT__38(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:16: T__39
    		{
    		DebugLocation(1, 16);
    		mT__39(); 

    		}
    		break;
    	case 3:
    		DebugEnterAlt(3);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:22: T__40
    		{
    		DebugLocation(1, 22);
    		mT__40(); 

    		}
    		break;
    	case 4:
    		DebugEnterAlt(4);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:28: T__41
    		{
    		DebugLocation(1, 28);
    		mT__41(); 

    		}
    		break;
    	case 5:
    		DebugEnterAlt(5);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:34: T__42
    		{
    		DebugLocation(1, 34);
    		mT__42(); 

    		}
    		break;
    	case 6:
    		DebugEnterAlt(6);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:40: T__43
    		{
    		DebugLocation(1, 40);
    		mT__43(); 

    		}
    		break;
    	case 7:
    		DebugEnterAlt(7);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:46: T__44
    		{
    		DebugLocation(1, 46);
    		mT__44(); 

    		}
    		break;
    	case 8:
    		DebugEnterAlt(8);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:52: T__45
    		{
    		DebugLocation(1, 52);
    		mT__45(); 

    		}
    		break;
    	case 9:
    		DebugEnterAlt(9);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:58: PRINT_KW
    		{
    		DebugLocation(1, 58);
    		mPRINT_KW(); 

    		}
    		break;
    	case 10:
    		DebugEnterAlt(10);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:67: IF_KW
    		{
    		DebugLocation(1, 67);
    		mIF_KW(); 

    		}
    		break;
    	case 11:
    		DebugEnterAlt(11);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:73: RETURN_KW
    		{
    		DebugLocation(1, 73);
    		mRETURN_KW(); 

    		}
    		break;
    	case 12:
    		DebugEnterAlt(12);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:83: FUNCTION_KW
    		{
    		DebugLocation(1, 83);
    		mFUNCTION_KW(); 

    		}
    		break;
    	case 13:
    		DebugEnterAlt(13);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:95: PROCEDURE_KW
    		{
    		DebugLocation(1, 95);
    		mPROCEDURE_KW(); 

    		}
    		break;
    	case 14:
    		DebugEnterAlt(14);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:108: LOCALS_KW
    		{
    		DebugLocation(1, 108);
    		mLOCALS_KW(); 

    		}
    		break;
    	case 15:
    		DebugEnterAlt(15);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:118: ELSE_KW
    		{
    		DebugLocation(1, 118);
    		mELSE_KW(); 

    		}
    		break;
    	case 16:
    		DebugEnterAlt(16);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:126: WHILE_KW
    		{
    		DebugLocation(1, 126);
    		mWHILE_KW(); 

    		}
    		break;
    	case 17:
    		DebugEnterAlt(17);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:135: OPERATOR
    		{
    		DebugLocation(1, 135);
    		mOPERATOR(); 

    		}
    		break;
    	case 18:
    		DebugEnterAlt(18);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:144: ID
    		{
    		DebugLocation(1, 144);
    		mID(); 

    		}
    		break;
    	case 19:
    		DebugEnterAlt(19);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:147: NUMBER
    		{
    		DebugLocation(1, 147);
    		mNUMBER(); 

    		}
    		break;
    	case 20:
    		DebugEnterAlt(20);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:154: STRING
    		{
    		DebugLocation(1, 154);
    		mSTRING(); 

    		}
    		break;
    	case 21:
    		DebugEnterAlt(21);
    		// D:\\Projects\\C#\\PseudoBF\\PseudoBF.Parsing\\PseudoBF.Parsing\\grammar\\PseudoBF.g:1:161: WHITESPACE
    		{
    		DebugLocation(1, 161);
    		mWHITESPACE(); 

    		}
    		break;

    	}

    }


	#region DFA
	DFA1 dfa1;
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1(this);
		dfa7 = new DFA7(this);
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\x06\uffff\x01\x0b\x01\x0d\x06\uffff";
		private const string DFA1_eofS =
			"\x0e\uffff";
		private const string DFA1_minS =
			"\x01\x21\x05\uffff\x02\x3d\x06\uffff";
		private const string DFA1_maxS =
			"\x01\x5e\x05\uffff\x02\x3d\x06\uffff";
		private const string DFA1_acceptS =
			"\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x02\uffff\x01\x08"+
			"\x01\x09\x01\x0a\x01\x06\x01\x0b\x01\x07";
		private const string DFA1_specialS =
			"\x0e\uffff}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x01\x09\x08\uffff\x01\x03\x01\x01\x01\uffff\x01\x02\x01\uffff\x01"+
				"\x04\x0c\uffff\x01\x06\x01\x08\x01\x07\x1f\uffff\x01\x05",
				"",
				"",
				"",
				"",
				"",
				"\x01\x0a",
				"\x01\x0c",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "115:1: OPERATOR : ( '+' | '-' | '*' | '/' | '^' | '<' | '>' | '==' | '!=' | '<=' | '>=' );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x08\uffff\x01\x15\x07\x11\x06\uffff\x01\x11\x01\x1f\x07\x11\x01\uffff"+
			"\x0a\x11\x01\x31\x01\x11\x01\x33\x04\x11\x01\uffff\x01\x38\x01\uffff"+
			"\x01\x11\x01\x3a\x01\x11\x01\x3c\x01\uffff\x01\x11\x01\uffff\x01\x11"+
			"\x01\uffff\x01\x11\x01\x40\x01\x41\x02\uffff";
		private const string DFA7_eofS =
			"\x42\uffff";
		private const string DFA7_minS =
			"\x01\x09\x07\uffff\x01\x3d\x01\x72\x01\x66\x01\x65\x01\x75\x01\x6f\x01"+
			"\x6c\x01\x68\x06\uffff\x01\x69\x01\x30\x01\x74\x01\x6e\x01\x63\x01\x73"+
			"\x01\x69\x01\x6e\x01\x63\x01\uffff\x01\x75\x01\x63\x01\x61\x01\x65\x01"+
			"\x6c\x01\x74\x01\x65\x01\x72\x01\x74\x01\x6c\x01\x30\x01\x65\x01\x30"+
			"\x01\x64\x01\x6e\x01\x69\x01\x73\x01\uffff\x01\x30\x01\uffff\x01\x75"+
			"\x01\x30\x01\x6f\x01\x30\x01\uffff\x01\x72\x01\uffff\x01\x6e\x01\uffff"+
			"\x01\x65\x02\x30\x02\uffff";
		private const string DFA7_maxS =
			"\x01\x7d\x07\uffff\x01\x3d\x01\x72\x01\x66\x01\x65\x01\x75\x01\x6f\x01"+
			"\x6c\x01\x68\x06\uffff\x01\x6f\x01\x7a\x01\x74\x01\x6e\x01\x63\x01\x73"+
			"\x01\x69\x01\x6e\x01\x63\x01\uffff\x01\x75\x01\x63\x01\x61\x01\x65\x01"+
			"\x6c\x01\x74\x01\x65\x01\x72\x01\x74\x01\x6c\x01\x7a\x01\x65\x01\x7a"+
			"\x01\x64\x01\x6e\x01\x69\x01\x73\x01\uffff\x01\x7a\x01\uffff\x01\x75"+
			"\x01\x7a\x01\x6f\x01\x7a\x01\uffff\x01\x72\x01\uffff\x01\x6e\x01\uffff"+
			"\x01\x65\x02\x7a\x02\uffff";
		private const string DFA7_acceptS =
			"\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x08"+
			"\uffff\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01\x08\x09\uffff\x01"+
			"\x0a\x11\uffff\x01\x0f\x01\uffff\x01\x09\x04\uffff\x01\x10\x01\uffff"+
			"\x01\x0b\x01\uffff\x01\x0e\x03\uffff\x01\x0c\x01\x0d";
		private const string DFA7_specialS =
			"\x42\uffff}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x02\x14\x01\uffff\x02\x14\x12\uffff\x01\x14\x01\x10\x01\x13\x05\uffff"+
				"\x01\x01\x01\x02\x02\x10\x01\x03\x01\x10\x01\uffff\x01\x10\x0a\x12\x01"+
				"\x04\x01\x06\x01\x10\x01\x08\x01\x10\x02\uffff\x1a\x11\x03\uffff\x01"+
				"\x10\x02\uffff\x04\x11\x01\x0e\x01\x0c\x02\x11\x01\x0a\x02\x11\x01\x0d"+
				"\x03\x11\x01\x09\x01\x11\x01\x0b\x04\x11\x01\x0f\x03\x11\x01\x05\x01"+
				"\uffff\x01\x07",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x10",
				"\x01\x16",
				"\x01\x17",
				"\x01\x18",
				"\x01\x19",
				"\x01\x1a",
				"\x01\x1b",
				"\x01\x1c",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x1d\x05\uffff\x01\x1e",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"\x01\x20",
				"\x01\x21",
				"\x01\x22",
				"\x01\x23",
				"\x01\x24",
				"\x01\x25",
				"\x01\x26",
				"",
				"\x01\x27",
				"\x01\x28",
				"\x01\x29",
				"\x01\x2a",
				"\x01\x2b",
				"\x01\x2c",
				"\x01\x2d",
				"\x01\x2e",
				"\x01\x2f",
				"\x01\x30",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"\x01\x32",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"\x01\x34",
				"\x01\x35",
				"\x01\x36",
				"\x01\x37",
				"",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"",
				"\x01\x39",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"\x01\x3b",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"",
				"\x01\x3d",
				"",
				"\x01\x3e",
				"",
				"\x01\x3f",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"\x0a\x11\x07\uffff\x1a\x11\x04\uffff\x01\x11\x01\uffff\x1a\x11",
				"",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 7;
			this.eot = DFA7_eot;
			this.eof = DFA7_eof;
			this.min = DFA7_min;
			this.max = DFA7_max;
			this.accept = DFA7_accept;
			this.special = DFA7_special;
			this.transition = DFA7_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | PRINT_KW | IF_KW | RETURN_KW | FUNCTION_KW | PROCEDURE_KW | LOCALS_KW | ELSE_KW | WHILE_KW | OPERATOR | ID | NUMBER | STRING | WHITESPACE );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
}