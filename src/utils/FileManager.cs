class FileWriter
{
    const string fileType = ".sql";
    const string fileName = "output";

    /// <summary>
    /// This method creates a file on specified path, writing the passed string into it
    /// </summary>
    public static void writeOnFile(string path, string outputString)
    {
        string[] outString = { outputString, "" };
        File.WriteAllLinesAsync(path + fileName + fileType, outString);
    }

    /// <summary>
    /// This method creates a file on specified path, writing the passed string into it
    /// </summary>
    public static void writeOnFile(string path, List<string> outputString)
    {
        File.WriteAllLinesAsync(path + fileName + fileType, outputString);
    }

    /// <summary>
    /// This method creates a file on specified path, writing the passed string into it
    /// </summary>
    public static void writeOnFile(string path, string[] outputString)
    {
        File.WriteAllLinesAsync(path + fileName + fileType, outputString);
    }
    /// #endregion

}

class FileReader{

    const string fileType = ".sql";

    /// <summary>
    /// This method reads from a specified file, returns all lines in an string array.
    /// </summary>
    public static string[] readFile(string path){
        return File.ReadAllLines(path+fileType);
    } 

    /// <summary>
    /// This method reads from a specified file, returns all lines in an string type.
    /// </summary>
    public static string readFile_ (string path){
        string[] file = readFile(path);
        string stringBuilder = "";

        foreach(string str in file){
            stringBuilder+= str;
        }

        return stringBuilder;
    }

}