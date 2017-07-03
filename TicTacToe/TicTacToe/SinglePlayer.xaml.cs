using System;
using System.Collections;
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
    /// Interaction logic for SinglePlayer.xaml
    /// </summary>
    public partial class SinglePlayer : Window
    {
        public SinglePlayer()
        {
            InitializeComponent();
            SPlayerName.Content = MainWindow.Player1Name;
        }

        private int PlayerWinCount = 0;
        private int PCWinCount = 0;

        private void IsWin(string winsymbol)
        {
           if(btn1.Content == btn2.Content && btn2.Content == btn3.Content && btn3.Content.ToString() == winsymbol ||
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
                    PlayerWinCount++;
                    PlayerWinsLabel.Content = PlayerWinCount.ToString();
                }

                if(winsymbol == "O")
                {
                    PCWinCount++;
                    PCWinsLabel.Content = PCWinCount.ToString();
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
        /*  
        Random rng = new Random();
        private void Shuffle(UIElementCollection list)
        {
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    UIElement value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
        }
        */
        private void ComputerTurn()
        {
            var result = ButtonsGrid.Children;
            //Shuffle(result); Shuffle Trying
            foreach (Control btn in result)
            {
                {
                    Button bt = btn as Button;
                    if (btn.IsEnabled == true)
                    {
                        bt.Content = "O";
                        bt.IsEnabled = false;
                        break;
                    }
                }
            }
        }

        private void Rest()
        {
            foreach(Control btn in ButtonsGrid.Children)
            {
                if (btn.GetType() == typeof(Button))
                {
                    Button bt = btn as Button;
                    bt.IsEnabled = true;
                    bt.Content = "";
                }
            }
        }



        private void Pressed(Button button)
        {
            button.Content = "X";
            button.IsEnabled = false;
            CheckTie();
            ComputerTurn();
            IsWin("X");
            IsWin("O");           
            
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Pressed(btn9);
        }
    }
}
