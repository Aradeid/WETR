using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace SWK5.Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChartValues<double> vs;
        RandomTemperatureGenerator generator;
        bool running = false;

        public MainWindow()
        {
            InitializeComponent();

            vs = new ChartValues<double>();
            generator = new RandomTemperatureGenerator(vs, 1000); // 1000 should come from an edit and be parsed on 'Start'

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperature",
                    Values = vs,
                    LineSmoothness = 0, //0 == straight lines
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    PointForeground = Brushes.Gray
                }
            };

            // Labels = new[] { };
            YFormatter = value => value.ToString();
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        //public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private void modeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                generator.Stop();
                running = false;
                // modeBtn.text = "Start";
            }
            else
            {
                generator.Start();
                running = true;
                // modeBtn.text = "Stop";
            }
        }
    }
}
