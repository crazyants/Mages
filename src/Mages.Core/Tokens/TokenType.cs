﻿namespace Mages.Core.Tokens
{
    /// <summary>
    /// The available token types.
    /// </summary>
    public enum TokenType
    {
        Unknown = 0,
        Keyword = 1,
        Identifier = 2,
        Number = 3,
        Unit = 4,
        Text = 5,
        OpenGroup = 6,
        CloseGroup = 7,
        OpenList = 8,
        CloseList = 9,
        OpenScope = 10,
        CloseScope = 11,
        Comma = 12,
        Colon = 13,
        Dot = 14,
        Power = 15,
        RightDivide = 16,
        LeftDivide = 17,
        Multiply = 18,
        Modulo = 19,
        Factorial = 20,
        Add = 21,
        Subtract = 22,
        Increment = 23,
        Decrement = 24,
        Or = 25,
        And = 26,
        Equal = 27,
        NotEqual = 28,
        Less = 29,
        LessEqual = 30,
        GreaterEqual = 31,
        Greater = 32,
        Negate = 33,
        Condition = 34,
        Transpose = 35,
        Trivia = 36,
        Assignment = 37,
        Lambda = 38,
        LineComment = 39,
        BlockComment = 40,
        SemiColon = 41,
        End = 0xffff,
    }
}
