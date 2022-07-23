using System.Drawing.Drawing2D;

namespace HW6ControlLibrary
{
    internal class PathGradient : Panel
    {
        public Color colorOne { get; set; }
        public Color colorTwo { get; set; }
        public float angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.colorOne, this.colorTwo, this.angle);
            Graphics graphic = e.Graphics;
            graphic.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);

        }
    }
}