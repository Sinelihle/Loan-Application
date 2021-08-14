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
    /// Interaction logic for SaveMoneyWPF.xaml
    /// </summary>
    public partial class SaveMoneyWPF : Window
    {
         
        public SaveMoneyWPF()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //declaring and initializing variable that sotres saving amount
            double saving;
            saving = Convert.ToDouble(boxAmount.Text) * (1 + (Convert.ToDouble(interestTextBox.Text.ToString())/ 100) *(Convert.ToInt32(savingPeriodBox.Text)));
            savingsAmountBox.Text ="Money Available for "+ reasonBox.Text+" is R "+ saving.ToString()+" after " + savingPeriodBox.Text + " years";
        }

        //handling slider exception
        private void interestSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (interestTextBox != null)
            {
                interestTextBox.Text = interestSlider.Value.ToString();
                int interestRate = Convert.ToInt32(interestTextBox.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}


