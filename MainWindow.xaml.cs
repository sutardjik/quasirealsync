﻿using System;
using System.Linq;
using System.Text;
using System.Windows;
using Npgsql;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace mysqlpostgres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connString = "server=localhost; uid=root; pwd=test123;database=test";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM persons", conn);
            conn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            testpersons.DataContext = dt;

            string connString1 = "server=localhost; uid=root; pwd=test123;database=demo";
            MySqlConnection conn1 = new MySqlConnection(connString1);
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM customers", conn1);
            conn1.Open();
            DataTable dt0 = new DataTable();
            dt0.Load(cmd1.ExecuteReader());
            conn1.Close();
            democustomers.DataContext = dt0;

            string connString3 = "server=localhost; uid=root; pwd=test123;database=sample";
            MySqlConnection conn3 = new MySqlConnection(connString3);
            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM employees", conn3);
            conn3.Open();
            DataTable dt3 = new DataTable();
            dt3.Load(cmd3.ExecuteReader());
            conn3.Close();
            sampleemployees.DataContext = dt3;

            string connString0 = "Host=localhost;Username=postgres;Password=postgres;Database=test";
            NpgsqlConnection conn0 = new NpgsqlConnection(connString0);
            NpgsqlCommand cmd0 = new NpgsqlCommand("SELECT * FROM persons", conn0);
            conn0.Open();
            DataTable dt1 = new DataTable();
            dt1.Load(cmd0.ExecuteReader());
            conn0.Close();
            pgtestpersons.DataContext = dt1;

            string connString2 = "Host=localhost;Username=postgres;Password=postgres;Database=demo";
            NpgsqlConnection conn2 = new NpgsqlConnection(connString2);
            NpgsqlCommand cmd2 = new NpgsqlCommand("SELECT * FROM customers", conn2);
            conn2.Open();
            DataTable dt2 = new DataTable();
            dt2.Load(cmd2.ExecuteReader());
            conn0.Close();
            pgdemocustomers.DataContext = dt2;

            string connString4 = "Host=localhost;Username=postgres;Password=postgres;Database=sample";
            NpgsqlConnection conn4 = new NpgsqlConnection(connString4);
            NpgsqlCommand cmd4 = new NpgsqlCommand("SELECT * FROM employees", conn4);
            conn4.Open();
            DataTable dt4 = new DataTable();
            dt4.Load(cmd4.ExecuteReader());
            conn4.Close();
            pgsampleemployees.DataContext = dt4;
        }

        private void InsertDemo_Click(object sender, RoutedEventArgs e)
        {
            InsertDemo insertDemo = new InsertDemo();
            insertDemo.Show();
            this.Hide();
        }

        private void InsertTest_Click(object sender, RoutedEventArgs e)
        {
            InsertTest insertTest = new InsertTest();
            insertTest.Show();
            this.Hide();
        }

        private void InsertSample_Click(object sender, RoutedEventArgs e)
        {
            InsertSample insertSample = new InsertSample();
            insertSample.Show();
            this.Hide();
        }

        private void UpdateDemo_Click(object sender, RoutedEventArgs e)
        {
            UpdateDemo updateDemo = new UpdateDemo();
            updateDemo.Show();
            this.Hide();
        }

        private void UpdateTest_Click(object sender, RoutedEventArgs e)
        {
            UpdateTest updateTest = new UpdateTest();
            updateTest.Show();
            this.Hide();
        }

        private void UpdateSample_Click(object sender, RoutedEventArgs e)
        {
            UpdateSample updateSample = new UpdateSample();
            updateSample.Show();
            this.Hide();
        }

        private void DeleteDemo_Click(object sender, RoutedEventArgs e)
        {
            DeleteDemo deleteDemo = new DeleteDemo();
            deleteDemo.Show();
            this.Hide();
        }

        private void DeleteTest_Click(object sender, RoutedEventArgs e)
        {
            DeleteTest deleteTest = new DeleteTest();
            deleteTest.Show();
            this.Hide();
        }

        private void DeleteSample_Click(object sender, RoutedEventArgs e)
        {
            DeleteSample deleteSample = new DeleteSample();
            deleteSample.Show();
            this.Hide();
        }

        private void QueryDB_Click(object sender, RoutedEventArgs e)
        {
            string connString = "server=localhost; uid=root; pwd=test123;database=test";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM persons", conn);
            conn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            testpersons.DataContext = dt;

            string connString1 = "server=localhost; uid=root; pwd=test123;database=demo";
            MySqlConnection conn1 = new MySqlConnection(connString1);
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM customers", conn1);
            conn1.Open();
            DataTable dt0 = new DataTable();
            dt0.Load(cmd1.ExecuteReader());
            conn1.Close();
            democustomers.DataContext = dt0;

            string connString3 = "server=localhost; uid=root; pwd=test123;database=sample";
            MySqlConnection conn3 = new MySqlConnection(connString3);
            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM employees", conn3);
            conn3.Open();
            DataTable dt3 = new DataTable();
            dt3.Load(cmd3.ExecuteReader());
            conn3.Close();
            sampleemployees.DataContext = dt3;

            string connString0 = "Host=localhost;Username=postgres;Password=postgres;Database=test";
            NpgsqlConnection conn0 = new NpgsqlConnection(connString0);
            NpgsqlCommand cmd0 = new NpgsqlCommand("SELECT * FROM persons", conn0);
            conn0.Open();
            DataTable dt1 = new DataTable();
            dt1.Load(cmd0.ExecuteReader());
            conn0.Close();
            pgtestpersons.DataContext = dt1;

            string connString2 = "Host=localhost;Username=postgres;Password=postgres;Database=demo";
            NpgsqlConnection conn2 = new NpgsqlConnection(connString2);
            NpgsqlCommand cmd2 = new NpgsqlCommand("SELECT * FROM customers", conn2);
            conn2.Open();
            DataTable dt2 = new DataTable();
            dt2.Load(cmd2.ExecuteReader());
            conn0.Close();
            pgdemocustomers.DataContext = dt2;

            string connString4 = "Host=localhost;Username=postgres;Password=postgres;Database=sample";
            NpgsqlConnection conn4 = new NpgsqlConnection(connString4);
            NpgsqlCommand cmd4 = new NpgsqlCommand("SELECT * FROM employees", conn4);
            conn4.Open();
            DataTable dt4 = new DataTable();
            dt4.Load(cmd4.ExecuteReader());
            conn4.Close();
            pgsampleemployees.DataContext = dt4;
        }

        private void dumpdb_Click(object sender, RoutedEventArgs e)
        {
            string connString = "server=localhost; uid=root; pwd=test123";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand("select schema_name from information_schema.schemata where schema_name not in('information_schema','mysql','performance_schema');", conn);
            conn.Open();
            string path = @".\\textfiles\\dumptext.txt";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                        dblist.Items.Add(row);
                    }
                }

                using (StreamWriter sw = new StreamWriter(path))
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (var item in dblist.Items)
                    {
                        stringBuilder.Append(item.ToString() + " ");
                    }
                    sw.WriteLine(stringBuilder.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MessageBox.Show("Dumping MySQL database(s). Please wait.", "Information");

                string mysqldumpPath = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysqldump";
                string dbFilePath = @".\textfiles\dumptext.txt";
                string db = File.ReadAllText(dbFilePath);

                string outputFilePath = @".\textfiles\dump.txt";

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = mysqldumpPath;
                process.StartInfo.Arguments = $"-u root --password=test123 --databases {db}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFilePath))
                {
                    process.Start();
                    sw.Write(process.StandardOutput.ReadToEnd());
                    process.WaitForExit();
                }

                MessageBox.Show("Dump completed. Please proceed to the 'STRIP' operation.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stripdb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = @".\\textfiles\\strip_dump.sh";
                    myProcess.StartInfo.CreateNoWindow = false;
                    myProcess.Start();
                    myProcess.WaitForExit();
                }

                MessageBox.Show("Strip completed. Please proceed to the 'LOAD' operation.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loaddb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Loading MySQL database dump to Postgres. Please wait.", "Information");

                string psqlPath = @"C:\Program Files\PostgreSQL\15\bin\psql";
                string postgresUser = "postgres";
                string inputFilePath = @".\textfiles\dumpinput.txt";

                System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                process1.StartInfo.FileName = psqlPath;
                process1.StartInfo.Arguments = $"-U {postgresUser}";
                process1.StartInfo.RedirectStandardInput = true;
                process1.StartInfo.UseShellExecute = false;

                using (System.IO.StreamReader sr = new System.IO.StreamReader(inputFilePath))
                {
                    process1.Start();
                    process1.StandardInput.Write(sr.ReadToEnd());
                    process1.StandardInput.Close();
                    process1.WaitForExit();
                }
                string mysqlPath = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql";
                string mysqlUser = "root";
                string mysqlPassword = "test123";
                string mysqlCommand = "flush binary logs;";

                System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                process2.StartInfo.FileName = mysqlPath;
                process2.StartInfo.Arguments = $"-u {mysqlUser} --password={mysqlPassword} -e \"{mysqlCommand}\"";
                process2.StartInfo.UseShellExecute = false;

                process2.Start();
                process2.WaitForExit();

                MessageBox.Show("Load completed. Click the 'QUERY DBs' tab to view the updated Postgres table(s).", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dumpbinlog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string searchPattern = "mysql-bin.0*";
                string[] files = Directory.GetFiles(@"C:\Program Files\MySQL\MySQL Server 5.6\data", searchPattern).OrderByDescending(f => new FileInfo(f).LastWriteTime).ToArray();
                if (files.Length > 0)
                {
                    string mostRecentFile = Path.GetFileName(files[0]);
                    binloginuse.Items.Clear();
                    binloginuse.Items.Add(mostRecentFile);
                    MessageBox.Show("Dumping MySQL binlog. Using binlog file: " + mostRecentFile + ". Please wait.", "Information");

                    string mysqlbinlogPath = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysqlbinlog";
                    string binlogFile = @"C:\Program Files\MySQL\MySQL Server 5.6\data\" + mostRecentFile;
                    string outputFilePath = @".\textfiles\transaction.txt";

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = mysqlbinlogPath;
                    process.StartInfo.Arguments = $"-short-form \"{binlogFile}\"";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;

                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFilePath))
                    {
                        process.Start();
                        sw.Write(process.StandardOutput.ReadToEnd());
                        process.WaitForExit();
                    }
                }

                string path = @".\textfiles\binlogtext.txt";
                try
                {
                    string lastItem = binloginuse.Items.OfType<string>().LastOrDefault();
                    if (lastItem != null)
                    {
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            sw.WriteLine(lastItem);
                        }
                        MessageBox.Show("Dump completed. Please proceed to the 'STRIP' operation.", "Information");
                    }
                    else
                    {
                        MessageBox.Show("No binlogs found in the list.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stripbinlog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = @".\\textfiles\\strip_transaction.sh";
                    myProcess.StartInfo.CreateNoWindow = false;
                    myProcess.Start();
                    myProcess.WaitForExit();
                }

                MessageBox.Show("Strip completed. Please proceed to the 'LOAD' operation.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadbinlog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Loading MySQL binlog to Postgres. Please wait.", "Information");

                string psqlPath = @"C:\Program Files\PostgreSQL\15\bin\psql";
                string postgresUser = "postgres";
                string inputFilePath = @".\textfiles\transactioninput.txt";

                System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                process1.StartInfo.FileName = psqlPath;
                process1.StartInfo.Arguments = $"-U {postgresUser}";
                process1.StartInfo.RedirectStandardInput = true;
                process1.StartInfo.UseShellExecute = false;

                using (System.IO.StreamReader sr = new System.IO.StreamReader(inputFilePath))
                {
                    process1.Start();
                    process1.StandardInput.Write(sr.ReadToEnd());
                    process1.StandardInput.Close();
                    process1.WaitForExit();
                }
                string mysqlPath = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql";
                string mysqlUser = "root";
                string mysqlPassword = "test123";
                string mysqlCommand = "flush binary logs;";

                System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                process2.StartInfo.FileName = mysqlPath;
                process2.StartInfo.Arguments = $"-u {mysqlUser} --password={mysqlPassword} -e \"{mysqlCommand}\"";
                process2.StartInfo.UseShellExecute = false;

                process2.Start();
                process2.WaitForExit();

                MessageBox.Show("Load completed. Click the 'QUERY DBs' tab to view the updated Postgres table(s).", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_app_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
