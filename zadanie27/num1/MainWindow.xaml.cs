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
using System.Xml;

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

            listbox1.Visibility = Visibility.Collapsed;
            textBlock1.Visibility = Visibility.Collapsed;
            treeView1.Visibility = Visibility.Collapsed;
        }

        public interface IDialogService
        {
            string FilePath { get; set; }
            bool OpenFileDialog();
        }

        public class DefaultDialogService : IDialogService
        {
            public string FilePath { get; set; }

            public bool OpenFileDialog()
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    FilePath = openFileDialog.FileName;
                    return true;
                }
                return false;
            }
        }

        public string path { get; set; }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            DefaultDialogService dfs = new DefaultDialogService();
            dfs.OpenFileDialog();

            path = dfs.FilePath;

            textBox2.Text = dfs.FilePath;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBlock_Checked_1(object sender, RoutedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Visible;
            listbox1.Visibility = Visibility.Collapsed;
            treeView1.Visibility = Visibility.Collapsed;
        }

        private void TreeView_Checked(object sender, RoutedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Collapsed;
            listbox1.Visibility = Visibility.Collapsed;
            treeView1.Visibility = Visibility.Visible;
        }

        private void ListBox_Checked(object sender, RoutedEventArgs e)
        {
            listbox1.Visibility = Visibility.Visible;
            textBlock1.Visibility = Visibility.Collapsed;
            treeView1.Visibility = Visibility.Collapsed;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text == "TextBox")
            {
                MessageBox.Show("Откройте файл!");
            }

            if (textBlock1.Visibility == Visibility.Collapsed &&
                listbox1.Visibility == Visibility.Collapsed &&
                treeView1.Visibility == Visibility.Collapsed)
            {
                MessageBox.Show("Выберите место ввода!");
            }

            StreamReader st = new StreamReader(path);

            if (textBlock1.Visibility == Visibility.Visible)
            {
                textBlock1.Text = st.ReadToEnd();
            }
            else if (listbox1.Visibility == Visibility.Visible)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);

                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlElement xnode in xRoot)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");

                    listbox1.Items.Add(attr.Value);
                }
            }
            else if (treeView1.Visibility == Visibility.Visible)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);

                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlElement xnode in xRoot)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");

                    treeView1.Items.Add(attr.Value);
                }
            }
        }
    }
}
