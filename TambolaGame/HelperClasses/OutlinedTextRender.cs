using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace TambolaGame.HelperClasses
{
    //protected override void OnRender(DrawingContext drawingContext)
    //{
    //    // Clear the background.
    //    Rect bg_rect = new Rect(0, 0, ActualWidth, ActualHeight);
    //    drawingContext.DrawRectangle(Brushes.White, null, bg_rect);

    //    // Create the FormattedText.
    //    const double fontsize = 70;
    //    FontFamily font_family = new FontFamily("Segoe");
    //    Typeface typeface = new Typeface("Segoe");
    //    FormattedText formatted_text =
    //        new FormattedText("Outlined\nText",
    //            new CultureInfo("en-us"), FlowDirection.LeftToRight,
    //            typeface, fontsize, Brushes.Black);
    //    formatted_text.SetFontWeight(FontWeights.Bold);

    //    // Center horizontally.
    //    formatted_text.TextAlignment = TextAlignment.Center;

    //    // Pick an origin to center the text.
    //    Point origin = new Point(
    //        grdMain.ActualWidth / 2,
    //        (grdMain.ActualHeight - formatted_text.Height) / 2);

    //    // Convert the text into geometry.
    //    Geometry geometry = formatted_text.BuildGeometry(origin);

    //    // Draw the geometry.
    //    Pen pen = new Pen(Brushes.Red, 2);
    //    drawingContext.DrawGeometry(Brushes.Yellow, pen, geometry);
    //}
}
