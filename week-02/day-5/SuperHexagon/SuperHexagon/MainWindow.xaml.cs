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
                        foxDraw.DrawLine(endPointW, endPointH, endPointW + 10, endPointH + 15);
                        startPointH = startPointH + 30;
                        endPointH = endPointH + 30;
                    }

                    }
                if (i > 3)
                {
                    startPointW = startPointW - i * 30;
                    endPointW = endPointW - i * 30; ;
                    startPointH = startPointH - i * 15;
                    endPointH = endPointH - i * 15;
                    for (int j = 5; j > 0 + i; j--)
                    {
                        foxDraw.StrokeColor(Colors.Black);

                        foxDraw.DrawLine(startPointW, startPointH, endPointW, endPointH);
                        foxDraw.DrawLine(endPointW, endPointH, endPointW + 10, endPointH + 15);
                        startPointH = startPointH + 30;
                        endPointH = endPointH + 30;
                    }
                }
            }

        }
    }
}

