using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Electron
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += (s, e) =>
            {
                int[] x = {-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5};
                int[] y = { 25, 16, 9, 4, 1, 0, 1,  4, 9, 16, 25 };

                double[] xd = x.Select(v => (double)v).ToArray();
                double[] yd = y.Select(v => (double)v).ToArray();

                Canvas.Plot.Add.Scatter(xd, yd);
                Canvas.Refresh();
            };
        }

    }
}