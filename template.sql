CREATE TABLE Funcionarios (
	id INT NOT NULL,
	nome varchar(100) NULL,
	cpf varchar(14) NULL,
	telefone varchar(14) NULL,
	email varchar(100) NULL,
	salario DOUBLE NULL,
	Funcionarios_PK PRIMARY KEY (id),
	cargaHoraria INT NOT NULL,
	Departamento varchar(100) NULL,
	Cargo varchar(100) NULL,
	dataAdmissão DATE NULL,
	dataDemissão DATE NULL,
	dataNascimento DATE NULL,
	nCarteiraDeTrabalho varchar(100) NULL,
	identidade varchar(11) NULL,
	contaCorrente varchar(15) NULL,
	endereço varchar(100) NULL,
	complemento varchar(100) NULL,
	numero INT NULL,
	bairro varchar(100) NULL,
	cidade varchar(100) NULL,
	genero TINYINT NULL
)

CREATE TABLE Fornecedores (
	id INT NULL,
	nome varchar(100) NULL,
	cnpj VARCHAR(16) NULL,
	endereco varchar(100) NULL,
	telefone varchar(100) NULL,
	email varchar(100) NULL
)

CREATE TABLE EmpresasParceiras (
	id INT NULL,
	nome varchar(100) NULL,
	cnpj varchar(16) NULL,
	endereco varchar(100) NULL,
	email varchar(100) NULL,
	telefone varchar(12) NULL,
	porcentagemDesconto INT NULL,
	nomeRepresentante varchar(100) NULL,
	inicioParceria DATE NULL,
	fimParceria DATE NULL
)

CREATE TABLE EmpresasClientes (
	id INT NULL,
	nome varchar(100) NULL,
	cnpj varchar(100) NULL,
	endereco varchar(100) NULL,
	email varchar(100) NULL,
	telefone varchar(12) NULL,
	numeroCompras INT NULL,
	representante varchar(100) NULL
)

CREATE TABLE Produto (
	id INT NULL,
	nome varchar(100) NULL,
	descricao varchar(100) NULL,
	valor DOUBLE NULL,
	quantidade INT NULL
)

CREATE TABLE Transportadora (
	id INT NULL,
	cnpj varchar(100) NULL,
	nome varchar(100) NULL,
	pedido INT NULL,
	empresa INT NULL
)

CREATE TABLE Vendas (
	id INT NULL,
	id_cliente INT NULL,
	dataVenda DATE NULL,
	id_fund_vendedor INT NULL
)

CREATE TABLE Pedidos (
	id INT NULL,
	id_produto INT NULL,
	id_transportadora INT NULL,
	id_venda INT NULL,
	id_cliente INT NULL
)

