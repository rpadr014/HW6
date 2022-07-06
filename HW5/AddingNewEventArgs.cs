using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class AddingNewEventArgs : EventArgs
    {
        public TextBoxBase passedTextBoxBase;
        public Font passedFont;

        public AddingNewEventArgs(TextBox propTextBox, Font passedFont)
        {
            passedTextBoxBase = propTextBox;
            this.passedFont = passedFont;
        }
    }
}
