using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// An example of a situation where you have one event handler to assign to multiple controls.
/// </summary>
namespace EventHandlerExample
{
    public partial class EventHandlerExampleForm : Form
    {
        public EventHandlerExampleForm()
        {
            InitializeComponent();
        }

        public void Checkbox_Checked(System.Object sender, System.EventArgs e) 
        {
            // Cast the sender object to a CheckBox and use its checked state/text to assign the display label.
            CheckBox senderCheck = (CheckBox)sender;
            DisplayLabel.Text = string.Format("\"{0}\" was {1}ed!", senderCheck.Text, senderCheck.Checked ? "check" : "uncheck");
        }

        private void EventHandlerExampleForm_Load(object sender, EventArgs e)
        {
            // Perhaps you are used to setting up event handlers via the GUI, but you can also set up events as needed.
            FirstCheck.CheckedChanged += new EventHandler(Checkbox_Checked);
            SecondCheck.CheckedChanged += new EventHandler(Checkbox_Checked);
            ThirdCheck.CheckedChanged += new EventHandler(Checkbox_Checked);
            FourthCheck.CheckedChanged += new EventHandler(Checkbox_Checked);
            FifthCheck.CheckedChanged += new EventHandler(Checkbox_Checked);
        }
    }
}
