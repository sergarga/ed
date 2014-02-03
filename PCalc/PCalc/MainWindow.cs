using System;
using Gtk;

//TODO Al hacer click en buttonSumar, sumar los números en entry1 y entry2 mostrando el resultado en entryResult

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
		//SUMA
		buttonSumar.Clicked+=delegate{
		double a=double.Parse (entry1.Text);
		double b=double.Parse (entry2.Text);
		entryResult.Text=Convert.ToString (a+b);	
		};
		
		//MULTIPLICACION
		buttonMultiplicacion.Clicked+=delegate{
		double a=double.Parse (entry1.Text);
		double b=double.Parse (entry2.Text);
		entryResult.Text=Convert.ToString (a*b);	
		};
		
		//DIVISION
		buttonDivision.Clicked+=delegate{
		double a=double.Parse (entry1.Text);
		double b=double.Parse (entry2.Text);
		entryResult.Text=Convert.ToString (a/b);	
		};
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
}
