using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Drawing
{
    /// <summary>
    /// Interaction logic for Lines.xaml
    /// </summary>

    public partial class PolylinesAndPolygons : System.Windows.Window
    {

        public PolylinesAndPolygons()
        {
            InitializeComponent();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void poly_MouseMove(object sender, MouseEventArgs e)
        {
            //poly.Points.Add(new Point(220, 260));
        }
    }
}