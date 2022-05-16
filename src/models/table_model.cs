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
        Regex tableNameRegex = new Regex("(?<=CREATE TABLE ).+?(?= \\()");
        Match tableNameMatch = tableNameRegex.Match(sql);
        this.name = tableNameMatch.ToString();
        
        this.attributes = new List<AttributeModel>();
    }
}
