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

namespace SWK5.Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TemperatureViewModel tvm = new TemperatureViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new TemperatureViewModel();
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            tvm.ReadCommand();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            tvm.StopCommand();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            tvm.ClearCommand();
        }
    }
}
