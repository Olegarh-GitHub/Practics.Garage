using System.Windows.Forms;
using System.Drawing;
using System;

namespace Practics.Garage.Forms.Controls
{
    public class InputControl: FlowLayoutPanel
    {
        private Label _label;
        private TextBox _textBox;

        public InputControl(string label)
        {
            Size = new Size(300, 50);
            _label = new Label()
            {
                Text = label,
                Size = new Size(250, 15)
            };
            _textBox = new TextBox()
            {
                Size = new Size(250, 25)
            };
            Controls.Add(_label);
            Controls.Add(_textBox);
        }

        public string GetData()
        {
            return _textBox.Text;
        }
    }
}
