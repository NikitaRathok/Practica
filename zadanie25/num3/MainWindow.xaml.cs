using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace num3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ChartArea chartArea1 = new ChartArea();
            myChart.ChartAreas.Add(chartArea1);


            Series series1 = new Series();
           

            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
            + 1;
            
            double[] x = new double[count];
           
            double[] y1 = new double[count];
            
           
            for (int i = 0; i < count; i++)
            {
                
                x[i] = Xmin + Step * i;
             
                y1[i] = -x[i];

            }
            myChart.Series.Add(series1);
            myChart.ChartAreas[0].AxisX.Minimum = Xmin;
            myChart.ChartAreas[0].AxisX.Maximum = Xmax;
          
            myChart.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            myChart.Series[0].Points.DataBindXY(x, y1);
        }
    }
}
