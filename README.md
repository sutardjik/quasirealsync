# QuasiRealSync

QuasiRealSync is a data replication tool that enables quasi-real-time migration from MySQL to PostgreSQL. Developed as a Windows Presentation Foundation (WPF) .NET 7.0 Desktop Application, the tool captures and parses binary logs from MySQL, transferring them to the target PostgreSQL databases for replication. The tool leverages C# and XAML for the frontend, Shell commands for database and log stripping processes, and SQL CRUD commands for MySQL database operations.

## Databases + Tables
- `test` database
	- `persons` table
- `sample` database
	- `employees` table
- `demo` database
	- `customers` table

## Miscellaneous
- Logs, output files, shell commands
	- `textfiles` folder
		- `binlogtext.txt`
		- `dump.txt`
		- `dumpinput.txt`
		- `dumptext.txt`
		- `transaction.txt`
		- `transactioninput.txt`
		- Shell script files (`.sh`)
			- `strip_dump.sh` for stripping MySQL database logs
			- `strip_transaction.sh` for stripping MySQL binary log transactions
- `Assets` folder
	- Icons provided by [Icons8](https://icons8.com/icons)
- MySQL script for databases, tables, values
	- `mysqlschemas.sql`

## Requirements
- Microsoft Visual Studio 2022 C# WPF (.NET 7.0)
- MySQL Server 5.6
	- Enable binary logging in `my.ini`
		- Set `log-bin` parameter as `mysql-bin`
- PostgreSQL 15