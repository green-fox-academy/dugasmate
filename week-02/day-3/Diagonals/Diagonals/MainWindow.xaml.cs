using drawing;
using System;
using System.Windows;
using System.Windows.Media;

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, canvas.Width, canvas.Height);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, canvas.Height, canvas.Width, 0);
        }
    }
}