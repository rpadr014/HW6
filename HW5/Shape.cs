using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    [Serializable]
    public enum PenType { Solid, CustomDashed, Compound }
    public enum BrushType { Solid, Hatch, LinearGradient }
    public enum ShapeType { Ellipse, Rectangle, Custom }
    public class Shape
    {
        public Shape()
        {

        }
        public PenType PenType { get; set; }
        public BrushType BrushType { get; set; }
        public Size Size { get; set; } = new Size(900, 800);
        public Point Location { get; set; } = new Point(100, 50);
        public String textTitle { get; set; } = "Untitled - ShapePad";
    }
}
