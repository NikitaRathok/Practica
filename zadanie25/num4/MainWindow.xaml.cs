using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<ButtonViewModel> Buttons { get; set; } = new ObservableCollection<ButtonViewModel>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public class ButtonViewModel
        {
            public string Content { get; set; }
            public int Row { get; set; }
            public int Column { get; set; }

            public ICommand Command { get; set; }

            public ButtonViewModel(string content, int row = 0, int column = 0, ICommand command = null)
            {
                Content = content;
                Row = row;
                Column = column;
                Command = command;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Collapsed;
        }

        private void btn(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            Buttons.Add(new ButtonViewModel($"кнопка {rand.Next(1, 3)}", rand.Next(1, 3), rand.Next(1, 3)));
        }
    }
}
