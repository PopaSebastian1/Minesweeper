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
namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Data();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        
        {
            Button button = (Button)sender;
            Tile tile = button.DataContext as Tile;
            tile.Visibility = Visibility.Visible;
            //make the button unclickable
            button.IsEnabled = false;
            Img.Items.Refresh();
            if(tile.IsBomb==true)
            {
                MessageBox.Show("You lost");
                this.Close();
            }
        }
    }

}
