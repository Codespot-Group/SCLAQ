using System.Text.RegularExpressions;
class TableModel
{
    public string name;
    public List<AttributeModel> attributes;

    public TableModel(string name, List<AttributeModel> attributes)
    {
        this.name = name;
        this.attributes = attributes;
    }

    public TableModel(string sql)
    {
        sql = sql.ToLower();
        sql = Regex.Replace(sql, @"\s+", " ");

        Regex tableNameRegex = new Regex(@"(?<=create table ).+?(?= \()");
        Match tableNameMatch = tableNameRegex.Match(sql);
        this.name = tableNameMatch.ToString();

        this.attributes = new List<AttributeModel>();
        Regex tableAttributesRegex = new Regex(@"(\w+)\s+(varchar|text|int|char)");
        foreach (Match match in tableAttributesRegex.Matches(sql))
        {
            string[] splited = match.ToString().Split(" ");
            this.attributes.Add(new AttributeModel(splited[0], splited[1]));
        }
    }

    static public List<TableModel> multiple(string sql)
    {
        sql = sql.ToLower();
        sql = Regex.Replace(sql, @"\s+", " ");

        List<TableModel> tables = new List<TableModel>();

        Regex regex = new Regex(@"create table(.*?);");

        foreach (Match match in regex.Matches(sql))
        {
            tables.Add(new TableModel(match.ToString()));
        }

        return tables;
    }
}
