using GreenFox;
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

namespace SuperHexagon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            HexaGo(foxDraw);
        }
        static void HexaGo(FoxDraw foxDraw)
        {

            for (int i = 0; i < 7; i++)
            {
                int startPointW = 80;
                int startPointH = 80;
                int endPointW = 100;
                int endPointH = 80;
                if (i <= 3)
                {
                    startPointW = startPointW + i * 30;
                    endPointW = endPointW + i * 30; ;
                    startPointH = startPointH - i * 15;
                    endPointH = endPointH - i * 15;
                    for (int j = 0; j < 5 + i; j++)
                    {
                        foxDraw.StrokeColor(Colors.Black);

                        foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                        if (j < 4 + i)
                        {
                            foxDraw.DrawLine(startPointW, startPointH + 30, endPointW - 30, endPointH + 15);
                            foxDraw.DrawLine(startPointW, startPointH, endPointW - 30, endPointH + 15);
                            startPointH = startPointH + 30;
                            endPointH = endPointH + 30;
                        }
                    }
                }
                startPointW = 80;
                startPointH = 80;
                endPointW = 100;
                endPointH = 80;
                if (i > 3)
                {

                    startPointW = startPointW - i * 30;
                    endPointW = endPointW - i * 30; ;
                    startPointH = startPointH - i * 15;
                    endPointH = endPointH - i * 15;
                    for (int j = 11; j > 11 - i; j--)
                    {
                        if (j > 6)
                        {
                            foxDraw.DrawLine(endPointW, endPointH + 30, startPointW + 30, startPointH + 15);
                            foxDraw.DrawLine(endPointW, endPointH, startPointW + 30, startPointH + 15);
                        }
                        foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                        startPointH = startPointH + 30;
                        endPointH = endPointH + 30;
                    }
                }
            }

        }
    }
}

