using System;
using System.Windows;
using drawing;

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // Draw 3 lines with that function. Use loop for that.
            int x = 100;
            int y = 100;

            for (int i = 0; i < 3; i++)
            {
                LineDrawer(foxDraw, x, y * i);
            }


        }

        static void LineDrawer(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, 50, y);
        }
    }
}