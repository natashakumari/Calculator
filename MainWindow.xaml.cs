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

namespace Natasha_Kumari_Final_Project
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
               ResultBlock.Text = (Convert.ToDouble(LeftText.Text) + Convert.ToDouble(RightText.Text)).ToString();
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
                ResultBlock.Text = (Convert.ToDouble(LeftText.Text) - Convert.ToDouble(RightText.Text)).ToString();

        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
                ResultBlock.Text = (Convert.ToDouble(LeftText.Text) * Convert.ToDouble(RightText.Text)).ToString();

        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            ResultBlock.Text = (Convert.ToDouble(LeftText.Text) / Convert.ToDouble(RightText.Text)).ToString();
        }

        private void PowButton_Click(object sender, RoutedEventArgs e)
        {
            int pow = Convert.ToInt32(RightText.Text);
            double val = Convert.ToDouble(LeftText.Text);
            double res = 0;

            
            for (int i = 0; i <= pow; i++)
            {
                res = val * i;
            }
            ResultBlock.Text = res.ToString();

        }
    }
}
