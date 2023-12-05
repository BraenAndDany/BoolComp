namespace booling;
using System;
public class booli 
{
    // Отдельные методы Не для каждой из возможных переменных
    public bool No(bool first)
    {
        return !first;

    }
    public bool And(bool first, bool second)
    {
        return first & second;
    }
  
    public bool Or(bool first, bool second)
    {
        return first | second;
    }

    public bool Xor(bool first, bool second)
    {
       return first ^ second;
    }
    public bool Xnor(bool first, bool second)
    {
        return first == second;
    }
    public bool Impl(bool first, bool second)
    {
        var a = Convert.ToInt32(first);
        var b = Convert.ToInt32(second);
        return a >= b;
    }
    public bool NoImpl(bool first, bool second)
    {
        var a = Convert.ToInt32(first);
        var b = Convert.ToInt32(second);
        return a <= b;
    }
}

