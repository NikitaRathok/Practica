using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using num2.Models;

namespace num2.Models
{
    internal class TestDraw:Control
    {
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            Rect rect = new Rect(new System.Windows.Point(160, 100), new System.Windows.Size(320, 80));
            drawingContext.DrawRectangle(System.Windows.Media.Brushes.LightBlue, (System.Windows.Media.Pen)null, rect);


            drawingContext.DrawEllipse(Brushes.Green, (Pen)null, new Point(123,11), 123, 123);
            drawingContext.DrawEllipse(Brushes.Black, (Pen)null, new Point(123, 11), 100, 100);
            drawingContext.DrawEllipse(Brushes.Orange, (Pen)null, new Point(123, 11), 60, 60);

            base.OnRender(drawingContext);
            
        }
    }
}
