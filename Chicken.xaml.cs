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
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ReturnButton2_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.MainWindow sW = new CDinner101.MainWindow();
            sW.Show();
            this.Close();
        }

        private void FingersnFriesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ChickenTenders/FriesOfChoice");
        }

        private void ChickenCasseroleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chicken/CreamOfChicken/Cracker");
        }

        private void HibachiButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chicken / Rice / Soy / Lemon / Egg / YumYum");
        }

        private void NuggetsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nuggets / FriesOrTots / Condiments / Dips");
        }

        private void AlfredoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chicken / Noodles / AlfredoSauce / Bread / Garlic");
        }

        private void Parm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chicken / TomatoSauce / Bread / Side / Garlic / Cheese");
        }
    }
}
