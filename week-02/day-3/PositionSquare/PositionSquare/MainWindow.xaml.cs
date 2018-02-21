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

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.        
            int x = 20;
            int y = 20;
            for (int i = 1; i <= 3; i++)
            {
                Squarez(foxDraw, x + i * 75, y + i * 75);
            }


        }
        static void Squarez(FoxDraw foxDraw, int x, int y)
        {
                foxDraw.DrawRectangle(x, y, 50, 50);
        }
    }
}
