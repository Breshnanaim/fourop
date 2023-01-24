using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace fourop
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

        private void addtion_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "+";
            string val1 = textb1.Text;
            string val2 = textb2.Text;
            double val11, val22 = 0;
            bool valaisnum = double.TryParse(val1,out
                val11);
            bool valaisum2 = double.TryParse(val2,out
                val22);
            if (valaisnum && valaisum2)
            {
                double addtion = val11 + val22;
                allinone.Text = addtion.ToString();
            }
            else
            {
                MessageBox.Show("Pplease enter number not litter");
            }
        }

        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "-";
            string val1 = textb1.Text;
            string val2 = textb2.Text;
            double val11, val22 = 0;
            bool valaisnum = double.TryParse(val1, out
                val11);
            bool valaisum2 = double.TryParse(val2, out
                val22);
            if (valaisnum && valaisum2)
            {
                double subtraction = val11 - val22;
                allinone.Text = subtraction.ToString();
            }
            else
            {
                MessageBox.Show("Pplease enter number not litter");
            }
        }

        private void multbotton_Click_1(object sender, RoutedEventArgs e)
        {
            label2.Content = "*";
            string mun1 = mul1.Text;
            string mun2 = mul2.Text;
            double mun3, mun4 = 0;
            bool multinum = double.TryParse(mun1, out
              mun3);
            bool multinum2 = double.TryParse(mun2, out
                mun4);
            if (multinum && multinum2)
            {
                double multbotton = mun4 * mun3;
                mul3.Text = multbotton.ToString();
            }
            else
            {
                MessageBox.Show("please enter number only");
            }
        }

        private void divtion_Click_2(object sender, RoutedEventArgs e)
        {
            label2.Content = "/";
            string mun1 = mul1.Text;
            string mun2 = mul2.Text;
            double mun3, mun4 = 0;
            bool multinum = double.TryParse(mun1, out
              mun3);
            bool multinum2 = double.TryParse(mun2, out
                mun4);
            if (multinum && multinum2)
            {
                double divtion = mun4 / mun3;
                mul3.Text = divtion.ToString();
            }
            else
            {
                MessageBox.Show("please enter number only");
            }
        }

        private void avergr_Click(object sender, RoutedEventArgs e)
        {
            
            string averget = mul3.Text;
            double averge = 0;
            //bool averge2 = double.TryParse(averget, out
              //  averge);
            double avergr = (averge / 2);
            avergetext.Text = avergr.ToString();
                
        }

        private void Averages(object sender, RoutedEventArgs e)
        {

        }
    }
}
