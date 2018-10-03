using System;
using Eto.Forms;

namespace FaceRecognition.Gtk
{
	class MainClass
	{
		[STAThread]
		public static void Main(string[] args)
		{
			new Application(Eto.Platforms.Gtk2).Run(new MainForm());
		}
	}
}
