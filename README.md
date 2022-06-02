# SCLAQ
An SQL code generator that will improve your performance. Just all you need to generate SQL code in one tool in your command line.

## Sumary
* [Introduction](#introduction)
* [How to install](#how-to-install)
* [How to run](#how-to-run)
  * [Flags](#flags) 
  * [Generate Commands](#generate-commands)
* [How to code](#how-to-code)
* [Features](#features)

## Introduction
This software helps you to generate random inserts based on your tables. It is built to improve your perfomance and make your life easier. You just need to set some flags on your create table, like this:

```sql
CREATE TABLE foo {
  id INT, 
  name VARCHAR(50), #ac.name 
  phone VARCHAR(14), #ac.phone
}
```

and after run, it will generate some code like this:

```sql
INSERT INTO foo(name,phone) VALUES ("John","+5575987989888");
INSERT INTO foo(name,phone) VALUES ("Doe","+5511987289388");
INSERT INTO foo(name,phone) VALUES ("Maria","+5575987989832");
INSERT INTO foo(name,phone) VALUES ("Andy","+5575987981238");
INSERT INTO foo(name,phone) VALUES ("Paul","+5575987912388");
```

### How to Install
* Download the [lastest release](https://github.com/Codespot-Group/SCLAQ/releases).
* Add to your environment path.
* Run `sclaq --help` on your favorite command line.

### How to run
#### Flags
The SCLAQ use some flags on SQL create statements to identify what kind of generators it will use. Check some of them below:

| name       | use                           |
| ---------- | ----------------------------- |
| #ac.name   | Generate random names         |
| #ac.phone  | Generate random phone numbers |
| #ac.number | Generate random numbers       |

#### Generate Commands
You can generate a defined quantity of inserts using `--count` flag. The following command generate ten inserts from all tables of .sql file called after `--path` flag.
```bash
$ sclaq generate --count 10 --path "<path-to-sql-create>"
```

Also you can use an MySQL connection and specify the table
```bash
$ sclaq generate --url "mysql://localhost:3306/mydbname" --table "<tablename>"
```

### How to Code
* Clone this repo in your machine.
* Make sure you have [Dotnet 6.0](https://dotnet.microsoft.com/en-us/download). 
* Run the code on your favorite IDE or via terminal using `dotnet run`.

# Features
All of features of SCLAQ are shown below:
- [ ] Generate insert code.
- [ ] Read an SQL create file.
- [ ] Read an MySQL database.
- [ ] Flags:
  - [x] Name. 
  - [ ] Phone Number.
  - [x] Random Number.
  - [ ] Male Name.
  - [ ] Female Name.
  - [ ] Random boolean.
  - [ ] Random date.
- [ ] Generate create code from database.
- [ ] Export to SQL file.
