using System.Data.SQLite;
class Program
{
    static void Main(string[] args)
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=src/database/db.sqlite;Version=3;");
        connection.Open();

        NameModel name = NameModel.randomFromDatabase(connection);

        System.Console.WriteLine(name.Value);
    }
}
