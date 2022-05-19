/// <summary>
/// This is an implementation of IAutoCodeType for name types.
/// 
/// Ex.: Felipe, Kovalski, ...
/// </summary>
public class AutoCodeTypeName : IAutoCodeType
{

    public static string generate()
    {
        string[] names = { "Felipe", "André", "Jean", "Leonardo" };
        int index = new Random().Next(names.Count());

        return names[index];
    }
    string IAutoCodeType.code
    {
        get { return "ac.name"; }
    }
    string IAutoCodeType.generate()
    {
        return AutoCodeTypeName.generate();
    }
}