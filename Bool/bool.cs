namespace booling;
public class booli 
{
    bool first;
    bool second;

    public void No(bool first, bool second)
    {
        if(first != second)
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
        if (first==prov&&second==prov)
        {
            Console.Write(true + "   ");
        }
        else
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

