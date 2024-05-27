using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace billing
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, RoutedEventArgs e)
        {
            //if (!string.IsNullOrEmpty(username))
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=practicelogin;Data Source=DESKTOP-D0C6LJ5\SQLEXPRESS;Encrypt= false";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                //sqlCommand.CommandText = "INSERT INTO EMOP VALUES('RAM', 23, 15000, 'ram')";
                sqlCommand.CommandText = $"INSERT INTO signup VALUES('{txtSignUser.Text}','{txtsignPass.Password}')";
                sqlCommand.ExecuteNonQuery();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=practicelogin;Data Source=DESKTOP-D0C6LJ5\SQLEXPRESS;Encrypt= false";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $"select count(*) from signup where  username='{txtUser.Text}'and Userpassword='{txtPass.Password}'";

            object value = sqlCommand.ExecuteScalar();

            MessageBox.Show("valid");


        }
    }
}
