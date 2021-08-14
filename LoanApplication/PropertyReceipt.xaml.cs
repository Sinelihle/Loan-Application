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
    /// Interaction logic for PropertyReceipt.xaml
    /// </summary>
    public partial class PropertyReceipt : Window
    {
        public PropertyReceipt()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //declaring variable to contain the total loan
            double totalLoan = 0;
            //initializing the loan variable and outputing it on the TextBlock
            totalLoan = (PropertyPurchase.PropertyPrice - PropertyPurchase.DepositPrice) * (1 + (PropertyPurchase.InterestRate/100) *(PropertyPurchase.NumberOfMonths/12));
            totalLoanBox.Text ="R " + totalLoan.ToString();

            //declaring variable to contain the monthly loan
            double monthlyPay = 0;
            //initializing the loan variable and outputing it on the TextBlock
            monthlyPay = totalLoan / PropertyPurchase.NumberOfMonths;
            monthlyLoanBox.Text = "R " + monthlyPay.ToString();

            double available = 0;
            available = HomeLoanWPF.GrossIncome - HomeLoanWPF.ExpenseTotal - HomeLoanWPF.MonthlyTax - monthlyPay;
            availableBox.Text ="R " + available.ToString();

            if(monthlyPay > HomeLoanWPF.GrossIncome / 3)
            {
                notifyBox.Text = "Approval Of Loan is very unlikely";
            }

            double GrossInc = 0;
            GrossInc = HomeLoanWPF.GrossIncome;
            grossBox.Text ="R " + GrossInc.ToString();

            double totalExpenditure = 0;
            totalExpenditure = HomeLoanWPF.ExpenseTotal + monthlyPay;
            totalExpenditureBox.Text ="R " +totalExpenditure.ToString();
        }
        //when the exit button is pressesd the current window is closed
        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        //this method goes back toprevious window
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            PropertyPurchase purchase = new PropertyPurchase();
            this.Hide();
            purchase.Show();
        }

        //this method closes current window and goes back to the vehicle window
        private void vehicleBtn_Click(object sender, RoutedEventArgs e)
        {
            VehicleLoanWPF vehicle = new VehicleLoanWPF();
            this.Hide();
            vehicle.Show();
        }
    }
   
}

