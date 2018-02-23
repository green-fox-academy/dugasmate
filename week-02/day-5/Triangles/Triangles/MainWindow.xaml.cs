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

namespace Triangles
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
            TriangleDraw(foxDraw);

        }

        static void TriangleDraw(FoxDraw foxDraw)
        {
            int startPointW = 0;
            int startPointH = 420;
            int endPointW = 420;
            int endPointH = 420;
            foxDraw.StrokeColor(Colors.Black);
            for (int i = 0; i < 21; i++)
            {

                foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                startPointW += 10;
                startPointH -= 20;
                endPointW -= 10;
                endPointH -= 20;

            }
            startPointW = 0;
            startPointH = 420;
            endPointW = 210;
            endPointH = 0;
            for (int i = 0; i < 21; i++)
            {

                foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                startPointW += 20;
                endPointW += 10;
                endPointH += 20;

            }
            startPointW = 420;
            startPointH = 420;
            endPointW = 210;
            endPointH = 0;
            for (int i = 0; i < 21; i++)
            {

                foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                startPointW -= 20;
                endPointW -= 10;
                endPointH += 20;

            }
        }
    }

}
