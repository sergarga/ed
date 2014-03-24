using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Gdk.Color greenColor = new Gdk.Color(0,255,0);
		
		int count = arrayButton.Rows * arrayButton.Columns;
		for (int index = 0; index < count; index++){
			arrayButton.Get(index).Label = string.Format ("{0}", index +1);
			if (index % 2 == 0 ){
				arrayButton[index].ModifyBg (StateType.Normal, greenColor);
			}
		}
		
		//arrayButton.Get (1,3).Label = "*";
		//arrayButton[2,4].Label = "**";
		
		//arrayButton.SetLabels (new string[] {"uno", "dos", "tres","cuatro","cinco","seis"});
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
