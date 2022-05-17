class Program
{
    static void Main(string[] args)
    {
        string sql = @"

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
        }
    }
}
