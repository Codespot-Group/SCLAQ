class AutoCode
{
    static public List<string> generate(TableModel table, int quantity = 10)
    {
        List<string> rows = new List<string>();

        for (int i = 0; i < quantity; i++)
        {
            List<string> attributes = new List<string>();
            List<string> values = new List<string>();
            foreach (AttributeModel attribute in table.attributes)
            {
                switch (attribute.type)
                {
                    case "int":
                        values.Add(AutoCodeTypeNumber.generate());
                        break;
                    case "varchar":
                        values.Add($"\"{AutoCodeTypeName.generate()}\"");
                        break;
                }

                attributes.Add(attribute.name);
            }

            rows.Add($"INSERT INTO {table.name}({String.Join(",", attributes)}) VALUES ({String.Join(",", values)});");
        }

        return rows;
    }
}