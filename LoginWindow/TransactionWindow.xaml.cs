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
using System.Windows.Shapes;

namespace LoginWindow
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {
        public TransactionWindow()
        {
            InitializeComponent();
        }

        Account Temp = new Account();

        public TransactionWindow(Account acc)
        {
            this.Temp = acc;
            InitializeComponent();
            Account_Number.Text = string.Format("#{0}", acc.Account_Number);
            Balance_Show.Text = string.Format("${0}", acc.Bank_Balance);
        }




        private void Deposit(object sender, RoutedEventArgs e)
        {
            float value;
            try
            {
                value = int.Parse(Edit_Bala.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Check The Input", "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);

                Edit_Bala.Clear();
                return;
            }


            AccountManager.Depsoit(Temp, value);
            Balance_Show.Text = string.Format("${0}", Temp.Bank_Balance);
            MessageBox.Show("Deposit Completed", "Sucessfull");

            Edit_Bala.Clear();

        }
        private void Withdraw(object sender, RoutedEventArgs e)
        {
            float value;
            try
            {
                value = int.Parse(Edit_Bala.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Check The Input", "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);

                Edit_Bala.Clear();
                return;
            }

            if (value > Temp.Bank_Balance)
            {
                MessageBox.Show("Insufficent Balance", "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);

                Edit_Bala.Clear();
                return;
            }

            else
            {
                AccountManager.WithDraw(Temp, value);
                Balance_Show.Text = string.Format("${0}", Temp.Bank_Balance);

                Edit_Bala.Clear();
                MessageBox.Show("Withdraw Completed", "Sucessfull");
            }
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            MainWindow m1 = new MainWindow();
            MessageBox.Show("Logout Sucessfull",
                "Sucessfull");
            AccountManager.Updatedatabase(Temp);

            this.Close();

           
            m1.Show();

        }


    }
}
