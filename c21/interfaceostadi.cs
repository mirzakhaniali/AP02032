

using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public abstract class operatordar
{
}

public interface IOPERATOR <t> where t : INumber<t>
{
    public t Operator(t x , t y);
}

public class sumop<t> : IOPERATOR<t> where t : INumber<t>
{
    public t Operator(t x , t y) => x+y;
}

public class subtractop<t> : IOPERATOR<t> where t : INumber<t>
{
    public t Operator(t x , t y) => x-y;
}

public class multiplyop<t> : IOPERATOR<t> where t: INumber<t>
{
    public t Operator(t x , t y) => x*y;
}

