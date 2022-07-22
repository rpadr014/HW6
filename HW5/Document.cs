using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    [Serializable]
    public class Document
    {
        public List<Rectangle> rectangles { get; set; } = new List<Rectangle>();
    }
}
