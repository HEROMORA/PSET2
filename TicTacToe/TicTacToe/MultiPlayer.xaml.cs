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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MultiPlayer.xaml
    /// </summary>
    public partial class MultiPlayer : Window
    {
        public MultiPlayer()
        {
            InitializeComponent();
            SPlayerName.Content = MainWindow.Player1Name.ToString();
            player2namelabel.Content = MainWindow.Player2Name.ToString();
        }

        private int Player1WinCount = 0;
        private int Player2WinCount = 0;

        private void Rest()
        {
            foreach (Control btn in ButtonsGrid.Children)
            {
                if (btn.GetType() == typeof(Button))
                {
                    Button bt = btn as Button;
                    bt.IsEnabled = true;
                    bt.Content = "";
                }
            }
        }

        private void IsWin(string winsymbol)
        {
            if (btn1.Content == btn2.Content && btn2.Content == btn3.Content && btn3.Content.ToString() == winsymbol ||
               btn1.Content == btn4.Content && btn4.Content == btn7.Content && btn7.Content.ToString() == winsymbol ||
               btn1.Content == btn5.Content && btn5.Content == btn9.Content && btn9.Content.ToString() == winsymbol ||
               btn2.Content == btn5.Content && btn5.Content == btn8.Content && btn8.Content.ToString() == winsymbol ||
               btn3.Content == btn6.Content && btn6.Content == btn9.Content && btn9.Content.ToString() == winsymbol ||
               btn4.Content == btn5.Content && btn5.Content == btn6.Content && btn6.Content.ToString() == winsymbol ||
               btn7.Content == btn8.Content && btn8.Content == btn9.Content && btn9.Content.ToString() == winsymbol ||
               btn3.Content == btn5.Content && btn5.Content == btn7.Content && btn7.Content.ToString() == winsymbol
                 )
            {
                MessageBox.Show(string.Format("{0} Win", winsymbol));
                if (winsymbol == "X")
                {
                    Player1WinCount++;
                    Player1WinsLabel.Content = Player1WinCount.ToString();
                }

                if (winsymbol == "O")
                {
                    Player2WinCount++;
                    Player2WinsLabel.Content = Player2WinCount.ToString();
                }
                Rest();
            }

        }

        private void CheckTie()
        {
            int counter = 0;
            foreach (Control btn in ButtonsGrid.Children)
            {
                if (btn.GetType() == typeof(Button))
                {
                    Button bt = btn as Button;
                    if (bt.IsEnabled == false)
                        counter++;

                    if (counter == 9)
                    {
                        MessageBox.Show("The Game is Tie");
                        Rest();
                    }
                }
            }
        }


        private int turn = 1;
        private void Press(Button button)
        {
            if (turn == 1)
            {
                button.Content = "X";
                turn = 2;
            }
            else
            {
                button.Content = "O";
                turn = 1;
            }
            button.IsEnabled = false;

            IsWin("X");
            IsWin("O");
            CheckTie();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Press(btn1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Press(btn2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Press(btn3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Press(btn4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Press(btn5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Press(btn6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Press(btn7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Press(btn8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Press(btn9);
        }
    }
}
