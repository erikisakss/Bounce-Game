using System;
using System.Windows.Forms;
using System.Drawing;

namespace Bounce
{
	public class MainForm : Form
	{
		public MainForm() : base()
		{
			Text = "Bounce!";
            BackColor = Color.Black;
            Width = 800;
			Height = 600;
			DoubleBuffered = true;
		}

     
    }
}
