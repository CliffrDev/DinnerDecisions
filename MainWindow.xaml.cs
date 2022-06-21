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

namespace CDinner101
{
    /// <summary>
    /// events for button click to open appropriate window
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BeefButton_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.Window1 sW = new CDinner101.Window1();
            sW.Show();
            this.Close();
        }

        private void PorkButton_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.Window3 sW = new CDinner101.Window3();
            sW.Show();
            this.Close();
        }

        private void ChickenButton_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.Window2 sW = new CDinner101.Window2();
            sW.Show();
            this.Close();
        }

        private void DineInButton_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.Window4 sW = new CDinner101.Window4();
            sW.Show();
            this.Close();
        }

        private void FastFoodButton_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.FastFood sW = new CDinner101.FastFood();
            sW.Show();
            this.Close();
        }
    }
    }

