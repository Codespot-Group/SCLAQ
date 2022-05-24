using System.Data.SQLite;

class NameModel
{
    public NameModel(string? value)
    {
        this.Value = value;
    }

    static public NameModel randomFromDatabase(SQLiteConnection connection)
    {
        SQLiteDataReader reader = new SQLiteCommand("SELECT value FROM names ORDER BY RANDOM() LIMIT 1;", connection).ExecuteReader();
        reader.Read();


        return new NameModel(reader["value"].ToString());
    }

    public string? Value { get; set; }


}