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

namespace LoanApplication
{
    /// <summary>
    /// Interaction logic for VehicleLoanWPF.xaml
    /// </summary>
    public partial class VehicleLoanWPF : Window
    {
        //declaring relevant variables
        static double vehiclePrice = 0;
        static double insurancePremium = 0;
        static double totalExpenses = 0;
        public VehicleLoanWPF()
        {
            InitializeComponent();
        }

        public static double TotalExpenses
        {
            get { return totalExpenses; }
        }
        public static double VehiclePrice
        {
            get { return vehiclePrice; }
            set { vehiclePrice = value; }
        }

        public static double InsurancePremium
        {
            get { return insurancePremium; }
            set { insurancePremium = value; }
        }

        private void txtPriceBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //handling exceptions
            try
            {
                vehiclePrice = Convert.ToDouble(txtPriceBox.Text);
            }
            catch (Exception)
            {

            }
           
        }

        private void txtDepositBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             PropertyPurchase.DepositPrice = Convert.ToDouble(txtDepositBox.Text);
            
        }

        private void interestSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (interestTextBox != null)
            {
                interestTextBox.Text = interestSlider.Value.ToString();
                PropertyPurchase.InterestRate = Convert.ToDouble(interestTextBox.Text);
            }
        }

        private void premiumBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                insurancePremium = Convert.ToDouble(premiumBox.Text);
            }
            catch (Exception)
            {

            }
           
        }

        //method to initialize text blocks
        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            modelBlock.Text ="Model And Make \t\t" + txtModelandMakeBox.Text;
            depositBlock.Text = "Total Deposit \t\t R" + txtDepositBox.Text;
            purchasePriceBlock.Text = "Purchase Price \t\t R" + txtPriceBox.Text;
            interestRateBlock.Text = "Interest Rate \t\t" + interestSlider.Value.ToString() + "%";
            insurancePremiumBlock.Text = "Insurance Premium \t R" + premiumBox.Text;
        }

        //method to return to previous window
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Hide();
            window.Show();
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            VehicleReceipt receipt = new VehicleReceipt();
            this.Hide();
            receipt.Show();
        }

        private void totalExpensesBtn_TextChanged(object sender, TextChangedEventArgs e)
        {
            totalExpenses = Convert.ToDouble(totalExpensesBtn.Text);
        }

        private void txtGrossIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                HomeLoanWPF.GrossIncome = Convert.ToDouble(txtGrossIncome.Text);

            }
            catch (Exception)
            {

            }
        }
    }
}
