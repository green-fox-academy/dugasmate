using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using drawing;

namespace GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            double canvasW = canvas.Width;
            double canvasH = canvas.Height;
            int x = 100;
            int y = 100;
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.
            DrawLiner(foxDraw, canvasW, canvasH, x, y);


        }
        static void DrawLiner (FoxDraw foxDraw, double canvasW, double canvasH, int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(x + i * 50, y , canvasW / 2, canvasH / 2);
            }

        }
    }
}