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

namespace LinePlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw);


        }
        public static void DrawLines(FoxDraw foxDraw)
        {
            int startPointW = 40;
            int startPointH = 20;
            int endPointW = 320;
            int endPointH = 40;
            for (int i = 0; i <= 28; i++)
            {
                if (i < 14)
                {
                    foxDraw.StrokeColor(Colors.Purple);
                    foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                    startPointW = startPointW + 20;
                    endPointH = endPointH + 20;
                }
                 else if (i == 14)
                {
                    startPointW = 20;
                    startPointH = 40;
                    endPointW = 40;
                    endPointH = 320;
                }
                else if (i > 14)
                {
                    foxDraw.StrokeColor(Colors.Green);
                    foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                    startPointH = startPointH + 20;
                    endPointW = endPointW + 20;
                }
            }

        }
    }
}
