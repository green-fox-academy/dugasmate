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

namespace PurpleSteps3d
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
                int size = 10;
                for (int i = 0; i < 6; i++)
                {
                    foxDraw.FillColor(Colors.Purple);
                    foxDraw.DrawRectangle(x, x, size, size);
                    x += size;
                    size += size;
                }


            }
        }
    
}
