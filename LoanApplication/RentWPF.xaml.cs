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
    /// Interaction logic for RentWPF.xaml
    /// </summary>
    public partial class RentWPF : Window
    {
        //declaring relevant variable
        static double rentAmount = 0;
        public RentWPF()
        {
            InitializeComponent();
        }


        public static double RentAmount
        {
            get { return rentAmount; }
        }
        private void rentBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //handling exception
            try
            {
                rentAmount = Convert.ToDouble(rentBox.Text);
            }
            catch (Exception)
            {

            }
           
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            //initialising text blocks
            displayRentBox.Text = "Rent Amount  \t" + rentBox.Text;
            displayGrossBox.Text = "Gross Income  \t" + HomeLoanWPF.GrossIncome.ToString();
            displayTax.Text ="Tax \t" + HomeLoanWPF.MonthlyTax.ToString();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeLoanWPF h = new HomeLoanWPF();
            this.Hide();
            h.Show();
        }

        private void vehicleBtn_Click(object sender, RoutedEventArgs e)
        {
            VehicleLoanWPF vl = new VehicleLoanWPF();
            this.Hide();
            vl.Show();
        }
    }
}
