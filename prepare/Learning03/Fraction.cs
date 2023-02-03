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
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string frac = _top + "/" + _bottom;
        return frac;
    }

    public double GetDecimalValue()
    {
        double fract_d = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
        return fract_d;
    }

}
