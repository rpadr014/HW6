using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    [Serializable]
    public class Features
    {
        public Features()
        {

        }
        public Color textColor { get; set; } = Color.Black;
        public Color textBackColor { get; set; } = Color.NavajoWhite;
        public Font textFont { get; set; } = SystemFonts.DefaultFont;
        public Size Size { get; set; } = new Size(900, 800);
        public Point Location { get; set; } = new Point(100, 50);
        public String textTitle { get; set; } = "Untitled - Notepad";
        public String text { get; set; } = "";
    }
}
