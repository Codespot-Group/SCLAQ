using System.Data.SQLite;
class Program
{
    static void Main(string[] args)
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=src/database/db.sqlite;Version=3;");
        connection.Open();

        NameModel name1 = NameModel.randomFromDatabase(connection);
        NameModel name2 = NameModel.randomFromDatabase(connection);
        NameModel name3 = NameModel.randomFromDatabase(connection);
        NameModel name4 = NameModel.randomFromDatabase(connection);

        FileWriter.writeOnFile("C:\\Users\\AndréLuizKovalski\\Documents\\Projects\\SCLAQ", 
        new List<String>{name1.Value, name2.Value, name3.Value, name4.Value});
    }
}
