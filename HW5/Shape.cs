using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public enum PenType { Solid, CustomDashed, Compound, None}
    public enum BrushType { Solid, Hatch, LinearGradient, None }
    public enum ShapeType { Ellipse, Rectangle, Custom, None }
    [Serializable]
    public class Shape
    {
        public Shape()
        {

        }
        public PenType PenType { get; set; } = PenType.None;
        public BrushType BrushType { get; set; } = BrushType.None;
        public ShapeType ShapeType { get; set; } = ShapeType.None;
        public Size ShapeSize { get; set; } = new Size(900, 800);
        public Point ShapeLocation { get; set; } = new Point(0,0);
        public String textTitle { get; set; } = "Untitled - ShapePad";
        public Color PenColor { get; set; } = Color.Black;
        public Color BrushColor { get; set; } = Color.Black;
        public float[] DashPattern { get; set; }
        [field: NonSerialized()] public Pen Pen { get; set; } = new Pen(Color.Black, 1);
        [field: NonSerialized()] public SolidBrush SolidBrush { get; set; } = new SolidBrush(Color.FromArgb(255, 0, 0, 255));

        public bool Contains(PointF point)
        {
            return point.X >= this.ShapeLocation.X && point.X <= this.ShapeLocation.X + this.ShapeSize.Width && point.Y >= this.ShapeLocation.Y && point.Y <= this.ShapeLocation.Y + this.ShapeSize.Height;
        }
    }
}
