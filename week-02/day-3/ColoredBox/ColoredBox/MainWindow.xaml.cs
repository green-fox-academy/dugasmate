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

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw a box that has different colored lines on each edge.
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(50, 50, 50, 100);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(50, 50, 100, 50);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(100, 50, 100, 100);
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(50, 100, 100, 100);

        }
    }
}
