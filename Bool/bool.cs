namespace booling;
public class booli 
{
    bool first;
    bool second;
    bool third;
    // Отдельные методы Не для каждой из возможных переменных
    public void NoX(bool first)
    {
        if(first != true)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    public void NoY(bool second)
    {
        if (second != true)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    public void NoZ(bool third)
    {
        if (third != true)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    public void And(bool first, bool second)
    {
        bool prov = true;
        if(first == prov && second == prov)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    //метод для трех значений с лог и
    public void AndForThree(bool first, bool second, bool third)
    {
        bool prov = true;
        if (first == prov && second == prov && third == prov)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    //метод для трех значений с лог не и и
    public void NoAndForThree(bool first, bool second, bool third)
    {
        bool prov = true;
        if (!first == prov || !second == prov || !third == prov)
        {
            
            Console.Write(true + "   ");
            
        }
        if (!first == prov! && !second! && prov! && !third == prov)
        {
            Console.Write(false + "   ");
        }
    }
    public void Or(bool first, bool second)
    {
        bool prov = true;
        if (first == prov || second == prov)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    public void OrForThree(bool first, bool second, bool third)
    {
        bool prov = true;
        if (first == prov || second == prov || third == prov)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    public void Xor(bool first, bool second)
    {
        bool prov = true;
        if (first == prov && second == prov)
        {
            Console.Write(false + "   ");
        }
        else
        {
            Console.Write(true + "   ");
        }
    }
    public void Xnor(bool first, bool second)
    {
        if (first == second)
        {
            Console.Write(true + "   ");
        }
        else
        {
                Console.Write(false + "   ");
        }
    }
    public void Impl(bool first, bool second)
    {
        if (first != true||first==second)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
    public void NoImpl(bool first, bool second)
    {
        if (first == second || first != false)
        {
            Console.Write(true + "   ");
        }
        else
        {
            Console.Write(false + "   ");
        }
    }
}

