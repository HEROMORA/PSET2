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

namespace TicTacToe
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

        private string playtype = "SinglePlayer";
        public static string Player1Name = "";
        public static string Player2Name = "";

        private void singleplayerbtn_Click(object sender, RoutedEventArgs e)
        {
            firstbox.IsEnabled = true;
            secondbox.IsEnabled = false;
            submitbtn.IsEnabled = true;
        }

        private void multiplayer_btn_Click(object sender, RoutedEventArgs e)
        {
            firstbox.IsEnabled = true;
            secondbox.IsEnabled = true;
            submitbtn.IsEnabled = true;
            playtype = "Multiplayer";
        }

        private void submitbtn_Click(object sender, RoutedEventArgs e)
        {

            Player1Name = firstbox.Text.ToString();
            if (playtype == "SinglePlayer")
            {
                SinglePlayer sp = new SinglePlayer();
                sp.ShowDialog();
            }
            else
            {
                Player2Name = secondbox.Text.ToString();
                // mp.ShowDialog();
            }
        }
    }
}
