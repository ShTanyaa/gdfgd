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

namespace практика_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        double c;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(t1.Text);
            double b = double.Parse(t2.Text);
            if(combo.SelectedIndex==0)
            {
                c = a + b;
                rez.Text = $"{c}";
            }
            if (combo.SelectedIndex == 1)
            {
                c = a - b;
                rez.Text = $"{c}";
            }
        }
    }
}
