using Bll;
using Model_Exam;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Account acc = new Account();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {

            
            acc.Account_Number = int.Parse(Account_Number.Text);
            acc.Password = Password.Text;
            }
            catch(Exception r)
            {
                MessageBox.Show("Please fill in all fields", "Error",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Error);
                Account_Number.Clear();
                Password.Clear();
            }

           Account acc2 = AccountManager.LoginCheck(acc);

            if(acc2.Account_Number==0)
            {
                MessageBox.Show("Inexisting account or wrong password", "Error",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Warning);
                Account_Number.Clear();
                Password.Clear();
            }

            else
            {
                MessageBox.Show("Login Sucesfull", "Login"
                                 );
                Account_Number.Clear();
                Password.Clear();

                TransactionWindow window = new TransactionWindow(acc2);
                this.Close();
                window.Show();
            }
           

        }
    }
}
