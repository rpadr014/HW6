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
    public enum ShapeType { Ellipse, Rectangle, Custom, None }
    public class Shape
    {
        public Shape()
        {

        }
        public PenType PenType { get; set; } = PenType.Solid;
        public BrushType BrushType { get; set; } = BrushType.Solid;
        public ShapeType ShapeType { get; set; } = ShapeType.None;
        public Size Size { get; set; } = new Size(900, 800);
        public Point Location { get; set; } = new Point(100, 50);
        public String textTitle { get; set; } = "Untitled - ShapePad";
        public Pen Pen { get; set; } = new Pen(Color.Black, 1);

        public bool Contains(PointF point)
        {
            return point.X >= this.Location.X && point.X <= this.Location.X + this.Size.Width && point.Y >= this.Location.Y && point.Y <= this.Location.Y + this.Size.Height;
        }
    }
}
