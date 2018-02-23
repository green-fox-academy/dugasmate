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
using GreenFox;

namespace ConnectTheDots
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 1 parameter:
            // A list of (x, y) points
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}
            double[][] parameterBox = new double[4][];
            parameterBox[0] = new double[] { 10, 10, 290, 10 };
            parameterBox[1] = new double[] { 290, 10, 290, 290 };
            parameterBox[2] = new double[] { 290, 290, 10, 290 };
            parameterBox[3] = new double[] { 10, 290, 10, 10 };

            double[][] parameterWhat = new double[7][];
            parameterWhat[0] = new double[] { 50, 100, 70, 70 };
            parameterWhat[1] = new double[] { 70, 70, 80, 90 };
            parameterWhat[2] = new double[] { 80, 90, 90, 90 };
            parameterWhat[3] = new double[] { 90, 90, 100, 70 };
            parameterWhat[4] = new double[] { 100, 70, 120, 100 };
            parameterWhat[5] = new double[] { 120, 100, 85, 130 };
            parameterWhat[6] = new double[] { 85, 130, 50, 100 };


            DrawStuff(foxDraw, parameterBox, parameterWhat);
        }
        static void DrawStuff(FoxDraw foxDraw, double[][] parameterBox, double[][] parameterWhat)
        {
            for (int i = 0; i < parameterBox.Length; i++)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(parameterBox[i][0], parameterBox[i][1], parameterBox[i][2], parameterBox[i][3]);
            }
            for (int i = 0; i < parameterWhat.Length; i++)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(parameterWhat[i][0], parameterWhat[i][1], parameterWhat[i][2], parameterWhat[i][3]);
            }


        }
    }

}