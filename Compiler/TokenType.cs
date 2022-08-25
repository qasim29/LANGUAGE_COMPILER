public enum TokenType
{
    DATA_TYPE,
    IF,
    ELSE,
    WHILE,
    LOOP_KEYWORDS,
    PM, //PLUS-MINUS
    MDM, // MULTIPLY,DIVIDE,MODULOUS
    COMP, //COMPARISION OPERATORS
    NOT,
    FUNC,
    RETURN,
    SEMI_COLON,
    COLON,
    COMMA,
    OPEN_ROUND_BRACKET,
    CLOSE_ROUND_BRACKET,
    OPEN_SQUARE_BRACKET,
    CLOSE_SQUARE_BRACKET,
    OPEN_CURLY_BRACKET,
    CLOSE_CURLY_BRACKET,
    
    /*   
        // OOP
    */    
    ACCESS_MODIFIER,
    CHILD_OF,   //EXTENDS
    ABSTRACT,
    STATIC,
    CREATE,     //NEW
    CLASS,
    SELF,       // THIS- KEYWORD
    SUPER,
    CONST,      //FINAL
    NULL
}