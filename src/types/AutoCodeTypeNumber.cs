/// <summary>
/// This is an implementation of IAutoCodeType for number types.
/// 
/// Ex.: 1, 3, 4...
/// </summary>
public class AutoCodeTypeNumber : IAutoCodeType
{

    public static string generate()
    {
        int index = new Random().Next(100);

        return index.ToString();
    }
    string IAutoCodeType.code
    {
        get { return "ca.number"; }
    }
    string IAutoCodeType.generate()
    {
        return AutoCodeTypeName.generate();
    }
}