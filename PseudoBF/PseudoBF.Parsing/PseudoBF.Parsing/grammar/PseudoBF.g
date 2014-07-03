grammar PseudoBF;

options {
    language=CSharp2;
    output=AST;
}

tokens {
	PROGRAM_IMAG;
	BLOCK_IMAG;
	SUBROUTINE_IMAG;
	LOCALS_IMAG;
	VARS_IMAG;
	CALL_IMAG;
	OPERATOR_CALL_IMAG;
	ASSIGN_IMAG;
	RETURN_IMAG;
	NUMBER_IMAG;
	VARIABLE_IMAG;
	IF_IMAG;
	ELSE_IMAG;
	WHILE_IMAG;
	STRING_IMAG;
	VALUES_IMAG;
	PRINT_IMAG;
}

@parser::namespace { PseudoBF.Parsing } 

@lexer::namespace { PseudoBF.Parsing }

@lexer::members {const int HIDDEN = Hidden;}

public program	:	subroutines EOF -> ^(PROGRAM_IMAG subroutines);

subroutines
	:	subroutine*;

subroutine
	:	subroutine_type ID variable_list locals_def code_block
		-> ^(SUBROUTINE_IMAG subroutine_type ID variable_list locals_def code_block);

subroutine_type
	:	FUNCTION_KW
	|	PROCEDURE_KW;
	
variable_list:	'(' ')' -> ^(VARS_IMAG)
	|	'(' ID (',' ID)* ')' -> ^(VARS_IMAG ID+);

value_list
	:	'(' ')' -> ^(VALUES_IMAG)
	|	'(' value (',' value)* ')' -> ^(VALUES_IMAG value+);

locals_def
	:	':' LOCALS_KW variable_list -> ^(LOCALS_IMAG variable_list)
	|	-> ^(LOCALS_IMAG);
	
code_block
	:	'{' (statement ';')* '}' -> ^(BLOCK_IMAG statement*);

statement
	:	assignment
	|	return_value
	|	call
	|	printcall
	|	if_
	|	while_;
	
if_	:	IF_KW '(' expression ')' code_block else_? -> ^(IF_IMAG expression code_block else_?);

else_ 	:	ELSE_KW code_block -> ^(ELSE_IMAG code_block);

while_	:	WHILE_KW '(' expression ')' code_block -> ^(WHILE_IMAG expression code_block);
	
assignment
	:	ID '=' expression -> ^(ASSIGN_IMAG ID expression);
	
expression
	:	value OPERATOR value -> ^(OPERATOR_CALL_IMAG OPERATOR value value)
	|	call
	|	value;
	
value	:	NUMBER -> ^(NUMBER_IMAG NUMBER)
	|	ID -> ^(VARIABLE_IMAG ID);
	
return_value
	:	RETURN_KW value -> ^(RETURN_IMAG value);

call	:	ID value_list -> ^(CALL_IMAG ID value_list);

printcall
	:	PRINT_KW '(' STRING ')' -> ^(PRINT_IMAG STRING);


PRINT_KW:	'print';

IF_KW	:	'if';

RETURN_KW
	:	'return';

FUNCTION_KW
	:	'function';
	
PROCEDURE_KW
	:	'procedure';

LOCALS_KW
	:	'locals';
	
ELSE_KW	:	'else';

WHILE_KW:	'while';

OPERATOR:	'+' | '-' | '*' | '/' | '^' | '<' | '>' | '==' | '!=' | '<=' | '>=';

ID	:	(CHAR) (IDCHAR)*;

NUMBER	:	DIGIT+;

STRING 	:	('"' (~'"')* '"');

fragment IDCHAR
	:	(CHAR | DIGIT | UNDERSCORE);

fragment UNDERSCORE
	:	'_';

fragment DIGIT	
	:	('0'..'9');

fragment CHAR	
	:	('a'..'z' | 'A'..'Z');

WHITESPACE : ( '\t' | ' ' | '\r' | '\n'| '\u000C' )+ 	{ $channel = HIDDEN; } ;

