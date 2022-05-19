class AttributeModel
{
    public string name { get; set; }
    public string type { get; set; }

    public AttributeModel(string name, string type)
    {
        this.name = name;
        this.type = type;
    }
}