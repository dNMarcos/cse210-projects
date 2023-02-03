using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
    }

    public Fraction(int top)
    {
        _bottom = 1;
    }

    private Fraction(int top, int bottom)
    {

    }

}
