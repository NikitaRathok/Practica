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

namespace num1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnRun.Click += BtnRun_Click;
            btnAdout.Click += BtnAdout_Click;
        }

       

        private void BtnRun_Click(object sender, RoutedEventArgs e)
        {
            string h = "Hello";
            string inp = string.Empty;
            if(string.IsNullOrEmpty(textBoxEnterName.Text)||string.IsNullOrWhiteSpace(textBoxEnterName.Text))
            {
                inp = "The World";
            }
            else
            {
                inp = textBoxEnterName.Text;
            }
            textBlockHello.Text = $"{h}{inp}";
        }
        private void BtnAdout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе {this.Title}";
            AboutApp aboutApp = new AboutApp(info);
            aboutApp.ShowDialog();

        }
    }
}
