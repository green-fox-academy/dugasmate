using System;
using System.Windows;
using System.Windows.Media;
using drawing;

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.
            // avoid code duplication.
                Squarez(foxDraw);



        }
        static void Squarez(FoxDraw foxDraw)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 4; i++)
            {
                foxDraw.DrawRectangle(10 * i, 10 * i, 150 * i, 50 * i);
                foxDraw.FillColor(
                    Color.FromRgb(
                    (byte)rnd.Next(255),
                    (byte)rnd.Next(255),
                    (byte)rnd.Next(255)
                    ));
            }
        }
    }
}