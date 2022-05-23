class Program
{
    static void Main(string[] args)
    {
        string sql = @"
            CREATE TABLE teste (
                id int,
                idade int #ac.number,
                name varchar #ac.name,
                numero varchar #ac.number
            );
        ";

        List<TableModel> tables = TableModel.multiple(sql);

        foreach (TableModel table in tables)
        {
            System.Console.WriteLine(table.name);

            foreach (AttributeModel attribute in table.attributes)
            {
                System.Console.WriteLine(attribute.name + "|" + attribute.type);
            }

            System.Console.WriteLine();

            List<string> inserts = AutoCode.generate(table);

            System.Console.WriteLine(String.Join("\n", inserts));
        }
    }
}
