using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Data.SqlClient;
namespace billing
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }



        private void txtsno1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem combo = (ComboBoxItem)txtsno1.SelectedItem;

            if (combo.Content.ToString() == "701")
            {
                txtpn1.Text = "apple";
            }
            else if (combo.Content.ToString() == "702")
            {
                txtpn1.Text = "orange";
            }
            else if (combo.Content.ToString() == "703")
            {
                txtpn1.Text = "papaya";
            }
            else if (combo.Content.ToString() == "704")
            {
                txtpn1.Text = "Amla";
            }
            else if (combo.Content.ToString() == "705")
            {
                txtpn1.Text = "lemon";

            }
        }

        private void txtsno2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //txtsno2
            ComboBoxItem combo2 = (ComboBoxItem)txtsno2.SelectedItem;
            if (combo2.Content.ToString() == "701")
            {
                txtpn2.Text = "apple";
            }
            else if (combo2.Content.ToString() == "702")
            {
                txtpn2.Text = "orange";
            }
            else if (combo2.Content.ToString() == "703")
            {
                txtpn2.Text = "papaya";
            }
            else if (combo2.Content.ToString() == "704")
            {
                txtpn2.Text = "Amla";
            }
            else if (combo2.Content.ToString() == "705")
            {
                txtpn2.Text = "lemon";

            }
        }

        private void txtsno3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //txtsno3
            ComboBoxItem combo3 = (ComboBoxItem)txtsno3.SelectedItem;
            if (combo3.Content.ToString() == "701")
            {
                txtpn3.Text = "apple";
            }
            else if (combo3.Content.ToString() == "702")
            {
                txtpn3.Text = "orange";
            }
            else if (combo3.Content.ToString() == "703")
            {
                txtpn3.Text = "papaya";
            }
            else if (combo3.Content.ToString() == "704")
            {
                txtpn3.Text = "Amla";
            }
            else if (combo3.Content.ToString() == "705")
            {
                txtpn3.Text = "lemon";

            }

        }

        private void txtsno4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //txtsno4
            ComboBoxItem combo4 = (ComboBoxItem)txtsno4.SelectedItem;
            if (combo4.Content.ToString() == "701")
            {
                txtpn4.Text = "apple";
            }
            else if (combo4.Content.ToString() == "702")
            {
                txtpn4.Text = "orange";
            }
            else if (combo4.Content.ToString() == "703")
            {
                txtpn4.Text = "papaya";
            }
            else if (combo4.Content.ToString() == "704")
            {
                txtpn4.Text = "Amla";
            }
            else if (combo4.Content.ToString() == "705")
            {
                txtpn4.Text = "lemon";

            }

        }

        private void txtsno5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //txtsno5
            ComboBoxItem combo5 = (ComboBoxItem)txtsno5.SelectedItem;
            if (combo5.Content.ToString() == "701")
            {
                txtpn5.Text = "apple";
            }
            else if (combo5.Content.ToString() == "702")
            {
                txtpn5.Text = "orange";
            }
            else if (combo5.Content.ToString() == "703")
            {
                txtpn5.Text = "papaya";
            }
            else if (combo5.Content.ToString() == "704")
            {
                txtpn5.Text = "Amla";
            }
            else if (combo5.Content.ToString() == "705")
            {
                txtpn5.Text = "lemon";

            }
        }
        private void txtq1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //price1
            if (txtpn1.Text == "apple")
            {

                int price = 100;
                int quantity = Convert.ToInt32(txtq1.Text);
                int total = price * quantity;
                txtpr1.Text = Convert.ToString(total);
            }
            else if (txtpn1.Text == "orange")
            {
                int price = 50;
                int quantity = Convert.ToInt32(txtq1.Text);
                int total = price * quantity;
                txtpr1.Text = Convert.ToString(total);
            }
            else if (txtpn1.Text == "Amla")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq1.Text);
                int total = price * quantity;
                txtpr1.Text = Convert.ToString(total);
            }
            else if (txtpn1.Text == "papaya")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq1.Text);
                int total = price * quantity;
                txtpr1.Text = Convert.ToString(total);
            }
            else if (txtpn1.Text == "lemon")
            {
                int price = 80;
                int quantity = Convert.ToInt32(txtq1.Text);
                int total = price * quantity;
                txtpr1.Text = Convert.ToString(total);
            }

        }

        private void txtq2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //price2
            if (txtpn2.Text == "apple")
            {

                int price = 100;
                int quantity = Convert.ToInt32(txtq2.Text);
                int total = price * quantity;
                txtpr2.Text = Convert.ToString(total);
            }
            else if (txtpn2.Text == "orange")
            {
                int price = 50;
                int quantity = Convert.ToInt32(txtq2.Text);
                int total = price * quantity;
                txtpr2.Text = Convert.ToString(total);
            }
            else if (txtpn2.Text == "Amla")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq2.Text);
                int total = price * quantity;
                txtpr2.Text = Convert.ToString(total);
            }
            else if (txtpn2.Text == "papaya")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq2.Text);
                int total = price * quantity;
                txtpr2.Text = Convert.ToString(total);
            }
            else if (txtpn1.Text == "lemon")
            {
                int price = 80;
                int quantity = Convert.ToInt32(txtq2.Text);
                int total = price * quantity;
                txtpr2.Text = Convert.ToString(total);
            }

        }

        private void txtq3_TextChanged(object sender, TextChangedEventArgs e)
        {
            //price3
            if (txtpn3.Text == "apple")
            {

                int price = 100;
                int quantity = Convert.ToInt32(txtq3.Text);
                int total = price * quantity;
                txtpr3.Text = Convert.ToString(total);
            }
            else if (txtpn3.Text == "orange")
            {
                int price = 50;
                int quantity = Convert.ToInt32(txtq3.Text);
                int total = price * quantity;
                txtpr3.Text = Convert.ToString(total);
            }
            else if (txtpn3.Text == "Amla")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq3.Text);
                int total = price * quantity;
                txtpr3.Text = Convert.ToString(total);
            }
            else if (txtpn3.Text == "papaya")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq3.Text);
                int total = price * quantity;
                txtpr3.Text = Convert.ToString(total);
            }
            else if (txtpn3.Text == "lemon")
            {
                int price = 80;
                int quantity = Convert.ToInt32(txtq3.Text);
                int total = price * quantity;
                txtpr3.Text = Convert.ToString(total);
            }

        }

        private void txtq4_TextChanged(object sender, TextChangedEventArgs e)
        {
            //price4
            if (txtpn4.Text == "apple")
            {

                int price = 100;
                int quantity = Convert.ToInt32(txtq4.Text);
                int total = price * quantity;
                txtpr4.Text = Convert.ToString(total);
            }
            else if (txtpn4.Text == "orange")
            {
                int price = 50;
                int quantity = Convert.ToInt32(txtq4.Text);
                int total = price * quantity;
                txtpr4.Text = Convert.ToString(total);
            }
            else if (txtpn4.Text == "Amla")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq4.Text);
                int total = price * quantity;
                txtpr4.Text = Convert.ToString(total);
            }
            else if (txtpn4.Text == "papaya")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq4.Text);
                int total = price * quantity;
                txtpr4.Text = Convert.ToString(total);
            }
            else if (txtpn4.Text == "lemon")
            {
                int price = 80;
                int quantity = Convert.ToInt32(txtq4.Text);
                int total = price * quantity;
                txtpr4.Text = Convert.ToString(total);
            }


        }

        private void txtq5_TextChanged(object sender, TextChangedEventArgs e)
        {

            //price5
            if (txtpn5.Text == "apple")
            {

                int price = 100;
                int quantity = Convert.ToInt32(txtq5.Text);
                int total = price * quantity;
                txtpr5.Text = Convert.ToString(total);
            }
            else if (txtpn5.Text == "orange")
            {
                int price = 50;
                int quantity = Convert.ToInt32(txtq5.Text);
                int total = price * quantity;
                txtpr5.Text = Convert.ToString(total);
            }
            else if (txtpn5.Text == "Amla")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq5.Text);
                int total = price * quantity;
                txtpr5.Text = Convert.ToString(total);
            }
            else if (txtpn5.Text == "papaya")
            {
                int price = 30;
                int quantity = Convert.ToInt32(txtq5.Text);
                int total = price * quantity;
                txtpr5.Text = Convert.ToString(total);
            }
            else if (txtpn5.Text == "lemon")
            {
                int price = 80;
                int quantity = Convert.ToInt32(txtq5.Text);
                int total = price * quantity;
                txtpr5.Text = Convert.ToString(total);
            }


        }
        private void btntotal_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;

            int[] total = new int[10];

            total[0]=Convert.ToInt32(txtpr1.Text);
            total[1] = Convert.ToInt32(txtpr2.Text);
            total[2] = Convert.ToInt32(txtpr3.Text);
            total[3] = Convert.ToInt32(txtpr4.Text);
            total[4] = Convert.ToInt32(txtpr5.Text);

            for (int i = 0 ; i < 4; i++){
                sum += total[i];
                

            }
            txttotal.Text = sum.ToString();
        }
    }
}