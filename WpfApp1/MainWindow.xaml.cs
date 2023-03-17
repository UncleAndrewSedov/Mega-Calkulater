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

namespace WpfApp1
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;          
            string Sum1 = textBox.Text;
            a = Convert.ToInt32(Sum1);
            string Sum2 = textBox1.Text;
            b = Convert.ToInt32(Sum2);
            c = a + b;
            textBox2.Text = c.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x, y, z;
            string M1 = textBox.Text;
            x = Convert.ToInt32(M1);
            string M2 = textBox1.Text;
            y = Convert.ToInt32(M2);
            z = x - y;
            textBox2.Text = z.ToString();
        }
    }
}
