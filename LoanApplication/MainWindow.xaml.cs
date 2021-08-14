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

namespace LoanApplication
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        //all these button event handlers hide the current window and open the chosen window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomeLoanWPF home = new HomeLoanWPF();
            this.Hide();
            home.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VehicleLoanWPF vehicle = new VehicleLoanWPF();
            this.Hide();
            vehicle.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SaveMoneyWPF save = new SaveMoneyWPF();
            this.Hide();
            save.Show();
        }
    }
}
