using drawing;
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

namespace MiddleLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Red);
            var startPoint = new Point(0, 150);
            var endPoint = new Point(600, 150);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.StrokeColor(Colors.Green);
            var startPoint2 = new Point(300, 0);
            var endPoint2 = new Point(300, 300);
            foxDraw.DrawLine(startPoint2, endPoint2);

        }
    }
}