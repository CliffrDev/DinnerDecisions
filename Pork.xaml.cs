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
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void ReturnButton1_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.MainWindow sW = new CDinner101.MainWindow();
            sW.Show();
            this.Close();
        }

        private void Pepp_QuesadillaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pepperoni / Tortilla / Cheese / TomatoSauce");
        }

        private void Breakfast_CasseroleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sausage / Gravy / Egg / Biscuit / Cheese / Tots");
        }

        private void BreakfastButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sausage / Bacon / Egg / biscuit / Gravy");
        }

        private void JumbalayaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Smoked Sausage / Rice / Cheese / Side");
        }

        private void Pork_ChopButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chops / Marinade / Dip / VegOfChoice / Bread");
        }

        private void PizzaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dough / TomatoSauce / Topping / Cheese");
        }
    }
}
