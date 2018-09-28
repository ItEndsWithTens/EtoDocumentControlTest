using System;
using Eto.Forms;
using Eto.Drawing;

namespace EtoDocumentControlTest
{
	partial class MainForm : Form
	{
		void InitializeComponent()
		{
			Title = "My Eto Form";
			ClientSize = new Size(400, 350);
			Padding = 10;

			var docPage = new DocumentPage { Text = "My tab is shy" };
			var docControl = new DocumentControl { Pages = { docPage } };
			
			Content = docControl;

			var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
			quitCommand.Executed += (sender, e) => Application.Instance.Quit();

			Menu = new MenuBar
			{
				Items =
				{
					new ButtonMenuItem { Text = "&File" },
				},
				QuitItem = quitCommand
			};
		}
	}
}
