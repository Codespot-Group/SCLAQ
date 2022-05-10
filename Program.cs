/// Types
/// #ca.name
/// #ca.phone
/// #ca.cpf
/// #ca.cep
/// #ca.name

public interface IAutoCodeType
{
    //public String code;

    public string code { get; }

    public string generate();
}

/// <summary>
/// This is an implementation of IAutoCodeType for name types.
/// 
/// Ex.: Felipe, Kovalski, ...
/// </summary>
public class AutoCodeTypeName : IAutoCodeType
{

    public static string generate()
    {
        return "Felipe";
    }

    string IAutoCodeType.code
    {
        get { return "ca.name"; }
    }
    string IAutoCodeType.generate()
    {
        return AutoCodeTypeName.generate();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AutoCodeTypeName.generate());
    }
}