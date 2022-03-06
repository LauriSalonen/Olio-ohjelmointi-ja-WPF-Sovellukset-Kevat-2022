using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Baml2006;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string dataSource = "localhost\\SQLEXPRESS";

        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            btn_GetTable.IsEnabled = false;
        }
        public void ConnectToDatabase()
        {
            try
            {
                string database = tb_Database.Text;
                string connectionString = "Data Source=" + dataSource + ";Database=" + database + ";Integrated Security=SSPI";
                connection = new SqlConnection(connectionString);

                connection.Open();
                MessageBox.Show("Connected To Database " + database + " Successfully");
                btn_GetTable.IsEnabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Database Connection Error \n" + e.Message);
            }
        }
        public void GetDatabaseTable()
        {
            try
            {
                string table = tb_Table.Text;
                string query = "SELECT * FROM " + table;
                ExecuteQuery(query);
           }
            catch (Exception e)
            {
                MessageBox.Show("Table Could Not Be  Loaded error: " + e.Message);
            }
        }

        public void ExecuteQuery(string query)
        {
            
            try
            {
                
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Data");
                sda.Fill(dt);
                dt_View.ItemsSource = dt.DefaultView;

            }
            catch (Exception e)
            {
                MessageBox.Show("Table Could Not Be  Loaded error: " + e.Message);
            }
        }

private void btn_Connect_Click(object sender, RoutedEventArgs e)
        {
            ConnectToDatabase();
        }

        private void btn_GetTable_Click(object sender, RoutedEventArgs e)
        {
            GetDatabaseTable();
        }

        private void exc_Query_Click(object sender, RoutedEventArgs e)
        {
            ExecuteQuery(query_texti.Text);
        }
    }
        }
    

