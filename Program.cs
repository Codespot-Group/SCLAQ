/// Types
/// #ca.name
/// #ca.phone
/// #ca.cpf
/// #ca.cep
/// #ca.name

public interface ICAType {
    //public String code;

    public string code { get; }

    public string generate();
}

/// <summary>
/// This is an implementation of ICAType for name types.
/// 
/// Ex.: Felipe, Kovalski, ...
/// </summary>
public class CATypeName : ICAType {
    
    public static string generate() {
        return "Felipe";
    }

    string ICAType.code {
        get { return "ca.name"; }
    }
    string ICAType.generate() {
        return CATypeName.generate();
    }    
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CATypeName.generate());
    }
}