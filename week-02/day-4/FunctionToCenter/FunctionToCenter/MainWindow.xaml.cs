using GreenFox;
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

namespace FunctionToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.
            double canvasW = canvas.Width;
            double canvasH = canvas.Height;
            double startPointW = 0;
            double startPointH = 0;

            CenterLiner(foxDraw, canvasW, canvasH, startPointW, startPointH);

        }
        static void CenterLiner(FoxDraw foxDraw, double canvasW, double canvasH, double startPointW, double startPointH)
        {
            for (int i = 0; i < 20; i++)
            {
                foxDraw.DrawLine(startPointW, startPointH, canvasW / 2, canvasH / 2);
                startPointH = startPointH + 20;
            }
            for (int i = 0; i < 20; i++)
            {
                foxDraw.DrawLine(startPointW, startPointH, canvasW / 2, canvasH / 2);
                startPointW = startPointW + 20;
            }
            for (int i = 0; i < 20; i++)
            {
                foxDraw.DrawLine(startPointW, startPointH, canvasW / 2, canvasH / 2);
                startPointH = startPointH - 20;
            }
            for (int i = 0; i < 20; i++)
            {
                foxDraw.DrawLine(startPointW, startPointH, canvasW / 2, canvasH / 2);
                startPointW = startPointW - 20;
            }


        }
    }
}