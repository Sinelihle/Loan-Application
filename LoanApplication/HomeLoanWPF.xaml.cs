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
    /// Interaction logic for HomeLoanWPF.xaml
    /// </summary>
    public partial class HomeLoanWPF : Window
    {
        //declaring varables to contain all necessary values
         static double grossIncome = 0;
         static double monthlyTax = 0;
         static List<double> monthlyExpenses = new List<double>();
         static double expensesTotal = 0;
        public HomeLoanWPF()
        {
            InitializeComponent();
        }

        public static double ExpenseTotal
        {
            get { return expensesTotal; }
            set { expensesTotal = value; }
        }
        public static double GrossIncome
        {
            get { return grossIncome; }
            set { grossIncome = value; }
        }

        public static double MonthlyTax
        {
            get { return monthlyTax; }
            set { monthlyTax = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            try
            {
                initializeExpenses();
                
                grossIncome = Convert.ToDouble(txtGross.Text);
                //initiaizing the total expense to relavant amount
                expensesTotal = monthlyExpenses.Sum();

                if (expensesTotal > grossIncome)
                {
                    MessageBox.Show("Expenses Exceed Gross Income");
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (expensesTotal < Convert.ToDouble(txtGross.Text))
                {
                    this.Hide();
                    PropertyPurchase property = new PropertyPurchase();
                    property.Show();
                }
                else
                {
                    //if the expense total not less than gross income the text boxes are cleared and the window remains open
                    ClearExpenses();
                    this.Show();
                }
            }
            catch (Exception)
            {

            }

           
            
        }
        //from this method including all the text chaged methods varables declared are initialized
        private void txtGross_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                grossIncome = Convert.ToDouble(txtGross.Text);
                if (grossIncome == -1 || grossIncome == 0)
                {
                    warnLbl.Content = "Gross Income can't be a zero or a negative number";
                }
            }
            catch (Exception)
            {

            }
      
        }

        private void txtTax_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                monthlyTax = Convert.ToDouble(txtTax.Text);

                if (monthlyTax > grossIncome)
                {
                    txtTax.Text = "";
                    warnLbl.Content = "Tax exceeds income";
                }
                else if(monthlyTax == -1 || monthlyTax == 0)
                {
                    warnLbl.Content = "Tax can't be a zero or a negative number";
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        //storing all the expenses into to the list 
        public void initializeExpenses()
        {
            try
            {
                monthlyExpenses.Add(Convert.ToDouble(txtGroceries.Text));
                monthlyExpenses.Add(Convert.ToDouble(txtWater.Text));
                monthlyExpenses.Add(Convert.ToDouble(txtTravel.Text));
                monthlyExpenses.Add(Convert.ToDouble(txtPhone.Text));
                monthlyExpenses.Add(Convert.ToDouble(txtOther.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //this method clears the text boxes if the expenses are greater than gross income
        public void ClearExpenses()
        {
            txtGroceries.Text = "";
            txtWater.Text = "";
            txtTravel.Text = "";
            txtPhone.Text = "";
            txtOther.Text = "";
        }

        //if the button isclicked the current window is closed and the rent window appears
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RentWPF rent = new RentWPF();
            this.Hide();
            rent.Show();
        }
    }
}
