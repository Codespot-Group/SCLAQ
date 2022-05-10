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