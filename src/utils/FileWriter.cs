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