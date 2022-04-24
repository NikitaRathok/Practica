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

namespace num4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnDell.Click += BtnDell_Click;
            btnDell.MouseMove += BtnDell_MouseMove;
        }

        private void BtnDell_MouseMove(object sender, MouseEventArgs e)
        {
           
            Random rand = new Random();
            Button b = (Button)sender;
            Button b1 = (Button)sender;
            b.MouseMove += B_MouseMove;
            int x2 = rand.Next(100,500);
            int y2 = rand.Next(100, 500);
            
            b.Margin = new Thickness(x2,y2,x2,y2);



        }

        private void B_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            Random rand = new Random();
            int x2 = rand.Next(100, 500);
            int y2 = rand.Next(100, 500);

            b.Margin = new Thickness(x2, y2, x2, y2);
        }

        private void BtnDell_Click(object sender, RoutedEventArgs e)
        {
            btnDell.Visibility = Visibility.Hidden;
           
        }

        
    }
}
