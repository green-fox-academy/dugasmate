
using System;
using System.Windows;
using drawing;

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.
            double size = 50; //;)
            double canvasW = canvas.Width;
            double canvasH = canvas.Height;
            for (int i = 3; i >= 1; i--)
            {
                CenterSquarez(foxDraw, size * i, canvasW, canvasH);
            }


        }
        static void CenterSquarez(FoxDraw foxDraw, double size, double canvasW, double canvasH)
        {
            foxDraw.DrawRectangle(canvasW / 2 - size / 2, canvasH / 2 - size / 2, size, size);
        }

    }
}
