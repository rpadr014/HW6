using HW5;
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
        public List<Shape> savedShapes { get; set; } = new List<Shape>();
    }
}
