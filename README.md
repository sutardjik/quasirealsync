# QuasiRealSync

QuasiRealSync is a replication tool that enables quasi-real-time data replication from MySQL to PostgreSQL. Developed as a Windows Presentation Foundation (WPF) .NET 7.0 Desktop Application, the tool captures and parses binary logs from MySQL, transferring them to the target PostgreSQL databases for replication. The tool leverages C# and XAML for the frontend, Shell commands for database and log stripping processes, and SQL CRUD commands for MySQL database operations.

## Development Utilities + Resources
- Logs, output files, Shell commands
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
- Clone this repository to local machine
- Microsoft Visual Studio 2022 C# WPF (.NET 7.0)
- MySQL Server 5.6
	- Enable binary logging in `my.ini`
		- Set `log-bin` parameter as `mysql-bin`
- PostgreSQL 15
	- Create a `.pgpass` file in the user's home directory to enable automatic authentication when connecting to PostgreSQL databases
		- In Windows, the home directory is typically `C:\Users\<username>`
			- Make sure to replace `<username>` with the actual username used on the system
	- Add the following line to the `.pgpass` file: `localhost:5432:postgres:postgres:postgres`
- Windows CMD
- Linux Shell