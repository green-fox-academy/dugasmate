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

namespace StarryNight
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)
            canvas.Background = Brushes.Black;
            Random rnd = new Random();
            Random random = new Random();

            for (int i = 0; i < 200; i++)
            {
                byte randomNumber = (byte)random.Next(100, 230);
                foxDraw.StrokeColor(Color.FromRgb(randomNumber, randomNumber,randomNumber));
                foxDraw.FillColor(Color.FromRgb(randomNumber, randomNumber, randomNumber));
                int x = rnd.Next(5, 955);
                int y = rnd.Next(5, 995);
                foxDraw.DrawRectangle(x, y, 5, 5);

            }


        }
    }
}
