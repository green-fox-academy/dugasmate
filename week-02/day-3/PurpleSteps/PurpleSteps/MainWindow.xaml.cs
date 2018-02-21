using System;
using System.Windows;
using drawing;
using System.Windows.Media;

namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]
            int x = 0;
            for (int i = 0; i < 20; i++)
            {
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, x , 10, 10);
                x += 10;
            }


        }
    }
}