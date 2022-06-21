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

namespace CDinner101
{
    /// <summary>
    /// Simple MessageBox ingredients and Return button
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ReturnButton0_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.MainWindow sW = new CDinner101.MainWindow();
            sW.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cheese / Beef / Dough / Veggies / Dips / Condiments");
        }

        private void Salisbury_SteakButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("SalSteaks / VegSide / BreadOfChoice");
        }

        private void BurgersButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Beef / Buns / Veggies / Condiments / FriesOrChips");
        }

        private void TacosButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Beef / Tortillas / Lettuce / Cheese / Tomatoes / Salsa");
        }

        private void Tot_CasseroleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tots / Cheese / Beef / Egg / Choice");
        }

        private void SpaghettiButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sauce / Beef / NoodleOfChoice");
        }

        private void TaquitosButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Taqs and Dip of Choice");
        }

        private void PastaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NoodleOfChoice / Sauce / Beef / Cheese / Garlic / Bread");
        }
    }
}
