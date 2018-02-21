using drawing;
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

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares.
            double size = 50; //;)
            Color[] color = new Color[]{Colors.Brown, Colors.Pink, Colors.Green, Colors.Indigo, Colors.Purple, Colors.Yellow, Colors.Orange, Colors.Red};
            double canvasW = canvas.Width;
            double canvasH = canvas.Height;
            for (int i = 7; i >= 0; i--)
            {
                foxDraw.FillColor(color[i]);
                CenterSquarez(foxDraw, size * i, canvasW, canvasH);

            }
             


        }
        static void CenterSquarez(FoxDraw foxDraw, double size, double canvasW, double canvasH)
        {

            foxDraw.DrawRectangle(canvasW / 2 - size / 2, canvasH / 2 - size / 2, size, size);


        }
    }
}
