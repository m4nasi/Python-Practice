using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tictactoe
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

        public void CheckWin(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            if ((TopXLeft.Content) == (TopXMiddle.Content) && (TopXMiddle.Content) == TopXRight.Content)
            {
                flag = 1;
            }
            else if (CenterXLeft.Content == CenterXMiddle.Content && CenterXMiddle.Content == CenterXRight.Content)
            {
                flag = 1;
            }
            else if (BottomXLeft.Content == BottomXMiddle.Content && BottomXMiddle.Content == BottomXRight.Content)
            {
                flag = 1;
            }
            else if (TopXLeft.Content == CenterXLeft.Content && CenterXLeft.Content == BottomXLeft.Content)
            {
                flag = 1;
            }
            else if (TopXMiddle.Content == CenterXMiddle.Content && CenterXMiddle.Content == BottomXMiddle.Content)
            {
                flag = 1;
            }
            else if (TopXRight.Content == CenterXRight.Content && CenterXRight.Content == BottomXRight.Content)
            {
                flag = 1;
            }
            else if (TopXLeft.Content == CenterXMiddle.Content && CenterXMiddle.Content == BottomXRight.Content)
            {
                flag = 1;
            }
            else if (TopXRight.Content == CenterXMiddle.Content && CenterXMiddle.Content == BottomXLeft.Content)
            {
                flag = 1;
            }
            /*
            else if (TopXLeft.Content != '1' && TopXRight.Content != '2' && arr[3] != '3' && arr[4] != '4' && CenterXMiddle.Content != '5' && CenterXRight.Content != '6' && BottomXLeft.Content != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            */
            else
            {
                flag = 0;
            }
        }

        private void Main(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            int[] SqrNum = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int player = 1;
            int flag = 0;
            var watch = new Stopwatch();
            TimeSpan time = watch.Elapsed;
            do
            {
                //flag = CheckWin();
            } while (flag != 1 && flag != -1);
        }



        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            TopXLeft.Content = "X";
        }

        private void ButtonClicked2(object sender, RoutedEventArgs e)
        {
            TopXMiddle.Content = "X";
        }

        private void ButtonClicked3(object sender, RoutedEventArgs e)
        {
            TopXRight.Content = "X";
        }
        private void ButtonClicked4(object sender, RoutedEventArgs e)
        {
            CenterXLeft.Content = "X";
        }
        private void ButtonClicked5(object sender, RoutedEventArgs e)
        {
            CenterXMiddle.Content = "X";
        }
        private void ButtonClicked6(object sender, RoutedEventArgs e)
        {
            CenterXRight.Content = "X";
        }
        private void ButtonClicked7(object sender, RoutedEventArgs e)
        {
            BottomXLeft.Content = "X";
        }
        private void ButtonClicked8(object sender, RoutedEventArgs e)
        {
            BottomXMiddle.Content = "X";
        }
        private void ButtonClicked9(object sender, RoutedEventArgs e)
        {
            BottomXRight.Content = "X";
        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            TopXLeft.Content = "1";
            TopXMiddle.Content = "2";
            TopXRight.Content = "3";
            CenterXLeft.Content = "4";
            CenterXMiddle.Content = "5";
            CenterXRight.Content = "6";
            BottomXLeft.Content = "7";
            BottomXMiddle.Content = "8";
            BottomXRight.Content = "9";
        }

    }
}
