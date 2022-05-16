class Program
{
    static void Main(string[] args)
    {
        string sql = @"
            CREATE TABLE Fornecedores (
                id INT NULL,
                nome varchar(100) NULL, 
                cnpj VARCHAR(16) NULL,
                endereco varchar(100) NULL,
                telefone varchar(100) NULL,
                email varchar(100) NULL
            );
        ";

        TableModel table = new TableModel(sql);

        System.Console.WriteLine(table.name);
    }
}
