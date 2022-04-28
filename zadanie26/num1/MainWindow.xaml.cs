using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using num1.Interfaces;
using num1.Models;
using num1.Share;

namespace num1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private bool IsFileOpened = false;
        private string _xmlFilePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintContries(_worker.GetAll());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCountryName.Text)
                || !string.IsNullOrWhiteSpace(textBoxDeleteCountryName.Text))
            {
                _worker.Delete(textBoxDeleteCountryName.Text);
                PrintContries(_worker.GetAll());
            }
        }

        private void PrintCountry(Country country)
        {
            textBlockXMLFileContent.Text = "==========Country========"
                + Environment.NewLine;
            textBlockXMLFileContent.Text += country?.ToString() ?? "Country not found";
        }

        private void PrintContries(List<Country> countries)
        {
            textBlockXMLFileContent.Text = "==========Contries========"
                + Environment.NewLine;
            
            foreach (var country in countries)
            {
                textBlockXMLFileContent.Text += country.ToString();
            }
        }

        private void textBoxCountryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountryName.Text))
            {
                PrintContries(_worker.GetAll());
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PrintContries(_worker.GetAll());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var country = _worker.FindBy(textBoxCountryName.Text);
            PrintCountry(country);
        }
    }
}
