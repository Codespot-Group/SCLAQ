class AttributeModel
{
    string name;
    AttributeType type;

    public AttributeModel(string name, AttributeType type)
    {
        this.name = name;
        this.type = type;
    }
}

enum AttributeType { varchar, floatNumber, intNumber, date }