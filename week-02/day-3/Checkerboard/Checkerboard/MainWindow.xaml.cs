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
using drawing;

namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            double startPoint = 0;
            double line = 0;
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Fill the canvas with a checkerboard pattern.
            double canvasW = canvas.Width;
            double canvasH = canvas.Height;
            foxDraw.FillColor(Colors.White);
            Checkers(foxDraw, startPoint, line, canvasW, canvasH);


        }
        static void Checkers(FoxDraw foxDraw, double startPoint, double line, double canvasW, double canvasH)
        {
            for (int i = 0; i < 8; i++)
            {
                int draw = 0;
                if (i % 2 == 0)
                {
                    draw = 0;
                }
                else if (i % 2 != 0)
                {
                    draw = 1;
                }

                for (int j = 0; j <= 8; j++)
                {
                    if (j == 8)
                    {
                        startPoint = 0;
                        line = line + canvasH / 8;

                    }
                    else if (j % 2 == draw)
                    {
                        foxDraw.FillColor(Colors.Black);
                        foxDraw.DrawRectangle(startPoint , line , canvasW / 8, canvasH / 8);
                        startPoint = startPoint + canvasW / 8;

                    }
                    else if (j % 2 != draw)
                    {
                        foxDraw.FillColor(Colors.White);
                        foxDraw.DrawRectangle(startPoint , line , canvasW / 8, canvasH / 8);
                        startPoint = startPoint + canvasW / 8;

                    }
                    

                }


            }


        }
    }

}
