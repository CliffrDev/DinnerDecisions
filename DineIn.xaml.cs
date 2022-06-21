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
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void ReturnButton4_Click(object sender, RoutedEventArgs e)
        {
            CDinner101.MainWindow sW = new CDinner101.MainWindow();
            sW.Show();
            this.Close();
        }

        private void MoesButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.moes.com/menu");
        }

        private void Little_TokyoButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://zmenu.com/little-tokyo-knoxville-online-menu/");
        }

        private void GondolierButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gondolierpizza.com/our-menu/");
        }

        private void La_FiestaButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.allmenus.com/tn/knoxville/682315-la-fiesta-mexican-restaurant-grill/menu/");
        }

        private void OsakaButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://order.osaka865.com/");
        }

        private void MP_Hibachi_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://zmenu.com/m-p-hibachi-grill-chinese-and-japanese-restaurant-alcoa-online-menu/");
        }
    }
}
