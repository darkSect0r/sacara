// Signature file for parser generated by fsyacc
module ES.Sacara.Ir.Parser.SacaraIrParser
type token = 
  | INTEGER of (int32)
  | LABEL of (string)
  | IDENTIFIER of (string)
  | STRING of (string)
  | INVOKE_DIRECTIVE of (string)
  | NCALL_DIRECTIVE
  | INCLUDE
  | SHIFTR_DIRECTIVE
  | SHIFTL_DIRECTIVE
  | XOR_DIRECTIVE
  | NOR_DIRECTIVE
  | INC_DIRECTIVE
  | NWRITEB_DIRECTIVE
  | NWRITEW_DIRECTIVE
  | NWRITEDW_DIRECTIVE
  | NREADB_DIRECTIVE
  | NREADW_DIRECTIVE
  | NREADDW_DIRECTIVE
  | WRITEB_DIRECTIVE
  | WRITEW_DIRECTIVE
  | WRITEDW_DIRECTIVE
  | READB_DIRECTIVE
  | READW_DIRECTIVE
  | READDW_DIRECTIVE
  | ADD_DIRECTIVE
  | SUB_DIRECTIVE
  | MUL_DIRECTIVE
  | DIV_DIRECTIVE
  | CMP_DIRECTIVE
  | AND_DIRECTIVE
  | OR_DIRECTIVE
  | LPAREN
  | RPAREN
  | JUMP_DIRECTIVE
  | MOV_DIRECTIVE
  | PLUS_OP
  | MINUS_OP
  | MUL_OP
  | DIV_OP
  | DIV
  | MOD
  | AND
  | SHIFTR
  | SHIFTL
  | OR
  | NOT
  | XOR
  | NOR
  | SETIP
  | SETSP
  | INC
  | EOF
  | CMP
  | GETSP
  | SWRITE
  | SREAD
  | BYTE
  | WORD
  | DWORD
  | NEWLINE
  | COMMA
  | SUB
  | MUL
  | GETIP
  | RET
  | JUMP
  | JUMPIFL
  | JUMPIFLE
  | JUMPIFG
  | JUMPIFGE
  | ALLOCA
  | HALT
  | PROC
  | ENDP
  | PUSH
  | POP
  | ADD
  | NOP
  | CALL
  | NCALL
  | WRITE
  | NWRITE
  | READ
  | NREAD
type tokenId = 
    | TOKEN_INTEGER
    | TOKEN_LABEL
    | TOKEN_IDENTIFIER
    | TOKEN_STRING
    | TOKEN_INVOKE_DIRECTIVE
    | TOKEN_NCALL_DIRECTIVE
    | TOKEN_INCLUDE
    | TOKEN_SHIFTR_DIRECTIVE
    | TOKEN_SHIFTL_DIRECTIVE
    | TOKEN_XOR_DIRECTIVE
    | TOKEN_NOR_DIRECTIVE
    | TOKEN_INC_DIRECTIVE
    | TOKEN_NWRITEB_DIRECTIVE
    | TOKEN_NWRITEW_DIRECTIVE
    | TOKEN_NWRITEDW_DIRECTIVE
    | TOKEN_NREADB_DIRECTIVE
    | TOKEN_NREADW_DIRECTIVE
    | TOKEN_NREADDW_DIRECTIVE
    | TOKEN_WRITEB_DIRECTIVE
    | TOKEN_WRITEW_DIRECTIVE
    | TOKEN_WRITEDW_DIRECTIVE
    | TOKEN_READB_DIRECTIVE
    | TOKEN_READW_DIRECTIVE
    | TOKEN_READDW_DIRECTIVE
    | TOKEN_ADD_DIRECTIVE
    | TOKEN_SUB_DIRECTIVE
    | TOKEN_MUL_DIRECTIVE
    | TOKEN_DIV_DIRECTIVE
    | TOKEN_CMP_DIRECTIVE
    | TOKEN_AND_DIRECTIVE
    | TOKEN_OR_DIRECTIVE
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_JUMP_DIRECTIVE
    | TOKEN_MOV_DIRECTIVE
    | TOKEN_PLUS_OP
    | TOKEN_MINUS_OP
    | TOKEN_MUL_OP
    | TOKEN_DIV_OP
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_AND
    | TOKEN_SHIFTR
    | TOKEN_SHIFTL
    | TOKEN_OR
    | TOKEN_NOT
    | TOKEN_XOR
    | TOKEN_NOR
    | TOKEN_SETIP
    | TOKEN_SETSP
    | TOKEN_INC
    | TOKEN_EOF
    | TOKEN_CMP
    | TOKEN_GETSP
    | TOKEN_SWRITE
    | TOKEN_SREAD
    | TOKEN_BYTE
    | TOKEN_WORD
    | TOKEN_DWORD
    | TOKEN_NEWLINE
    | TOKEN_COMMA
    | TOKEN_SUB
    | TOKEN_MUL
    | TOKEN_GETIP
    | TOKEN_RET
    | TOKEN_JUMP
    | TOKEN_JUMPIFL
    | TOKEN_JUMPIFLE
    | TOKEN_JUMPIFG
    | TOKEN_JUMPIFGE
    | TOKEN_ALLOCA
    | TOKEN_HALT
    | TOKEN_PROC
    | TOKEN_ENDP
    | TOKEN_PUSH
    | TOKEN_POP
    | TOKEN_ADD
    | TOKEN_NOP
    | TOKEN_CALL
    | TOKEN_NCALL
    | TOKEN_WRITE
    | TOKEN_NWRITE
    | TOKEN_READ
    | TOKEN_NREAD
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startprogram
    | NONTERM_program
    | NONTERM_sourceElementList
    | NONTERM_globalStatement
    | NONTERM_procDefinition
    | NONTERM_parameterList
    | NONTERM_statementList
    | NONTERM_statement
    | NONTERM_statementNoLabel
    | NONTERM_directives
    | NONTERM_argumentList
    | NONTERM_primaryExpression
    | NONTERM_expression
    | NONTERM_additiveExpression
    | NONTERM_multiplicativeExpression
    | NONTERM_integerList
    | NONTERM_dataList
    | NONTERM_data
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val program : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Program ) 
