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
    /// Interaction logic for VehicleReceipt.xaml
    /// </summary>
    /// declaring notification delegate
    public delegate void NotificationDel();
    public partial class VehicleReceipt : Window
    {
        public VehicleReceipt()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //declaring and initializing relevant varables to relevant text blocks
            double loan = 0;
            loan = (VehicleLoanWPF.VehiclePrice - PropertyPurchase.DepositPrice) * (1 + (PropertyPurchase.InterestRate / 100) * (5));
            
            double monthly = 0;
            monthly = (loan + VehicleLoanWPF.InsurancePremium)/ 12;

            //initializing the text blocks to relevant values
            vehicleMonthyCostBox.Text="R " + monthly.ToString();
            totalCostBox.Text ="R " + loan.ToString();
            purchasePriceBox.Text = "R "+ VehicleLoanWPF.VehiclePrice.ToString();
            depositBox.Text = "R "+ PropertyPurchase.DepositPrice.ToString();
            interestRateBox.Text = PropertyPurchase.InterestRate.ToString() + "%";
            NotificationDel notify = new NotificationDel(Notification);
            notify.Invoke();
        }

        //delcaring invoked method
        public void Notification()
        {
            try
            {
                double totalMonthlyExpenses = VehicleLoanWPF.TotalExpenses + (Convert.ToDouble(vehicleMonthyCostBox.Text) / 12);
                if (totalMonthlyExpenses > HomeLoanWPF.GrossIncome * 0.75)
                {
                    notifyBox.Text = "Your expenses exceed 75% of your income";
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VehicleLoanWPF vh = new VehicleLoanWPF();
            this.Hide();
            vh.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}

