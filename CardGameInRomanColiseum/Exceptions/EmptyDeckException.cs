﻿namespace CardGameInRomanColiseum.Exceptions;

public class EmptyDeckException : Exception
{
    public EmptyDeckException()
    {
        
    }

    public EmptyDeckException(string message) : base(message)
    {
        
    }
}