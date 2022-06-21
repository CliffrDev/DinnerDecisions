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
    /// Simple buttonClick to open menus and Return button
    /// </summary>
    public partial class FastFood : Window
    {
        public FastFood()
        {
            InitializeComponent();
        }

        private void ReturnButton3_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.MainWindow sW = new CDinner101.MainWindow();
            sW.Show();
            this.Close();
        }

        private void McDonaldsButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mcdonalds.com/us/en-us/full-menu.html");
        }

        private void TacoBellButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tacobell.com/food");
        }

        private void WendysButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wendys.com/en-uk/menu/our-menu");
        }

        private void SonicButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://order.sonicdrivein.com/?gclid=Cj0KCQjw2MWVBhCQARIsAIjbwoN872wo_xxOCSKxQxvE7xtoSiDn2wsWRRR7ovnNPEFnjsQXBBRD0A8aAr-FEALw_wcB");
        }

        private void LJSButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ljsilvers.com/menu/");
        }

        private void SubwayButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.subway.com/en-us/menu");
        }

        private void FirehouseButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.firehousesubs.com/our-food/");
        }

        private void BurgerKingButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bk.com/menu/");
        }

        private void BojanglesButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bojangles.com/menu/");
        }

        private void ZaxbysButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.zaxbys.com/menu/");
        }

        private void KrystalsButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.krystal.com/menu/");
        }

        private void CentralParkButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://zmenu.com/central-park-restaurant-knoxville-online-menu/");
        }
    }
    }
