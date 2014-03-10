using System;
using Gtk;
using System.Collections.Generic;
using System.Diagnostics;

public partial class MainWindow: Gtk.Window
{	
	private List<int> numeros;
	private List<Button> buttons = new List<Button>();
	private Table table, table2;
	private static readonly Gdk.Color COLOR_GREEN = new Gdk.Color(0,255,0);
	private uint numeroTotalBolas = 90;
	uint cont=0;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		table = new Table(((numeroTotalBolas-1)/10)+1,10,true);
		table2 = new Table(((numeroTotalBolas-1)/10)+1,10,true);
		vbox1.Add (table);
		vbox1.Add (table2);
		table.Visible = true;
		table2.Visible = true;
	   
		addButtons ();
		
		numeros=new List<int>();			
		
		for (int numero=1;numero<=numeroTotalBolas;numero++)
			numeros.Add (numero);
		
		showNumeros();
		
		buttonJugar.Clicked+=delegate{
			extractRndNumber();
		};
	}
	
	private void extractRndNumber(){
		
		Random rnd=new Random();
			int index = rnd.Next(numeros.Count);
			int numeroExtraido=numeros[index];
			
		
			labelNumero.Text="Ha salido el "+Convert.ToString (numeroExtraido);
			//Process.Start ("espeak", "-v es "+numeroExtraido);
			numeros.Remove(numeroExtraido);
			
			buttons[numeroExtraido-1].ModifyBg(StateType.Normal, COLOR_GREEN);
			addButton (numeroExtraido, cont);
			cont++;
			showNumeros();
		
	}
	
	private void addButtons(){
		
		for(uint index = 0; index < numeroTotalBolas; index++){
			
			Button button = new Button();
			button.Label=Convert.ToString(index+1);
			button.Visible=true;
		
			buttons.Add (button);	
		
			uint fila = index / 10;
			uint columna = index % 10;
			
			table.Attach(button, columna, columna+1, fila, fila+1);
		}	
		
	}
	
	private void addButton(int numeroExtraido, uint cont){
		
			Button button = new Button();
			button.Label=Convert.ToString(numeroExtraido);
			button.Visible=true;
		
		    uint fila = cont / 10;
			uint columna = cont % 10;
		
			table2.Attach(button, columna, columna+1, fila, fila+1);
		
	}
	
	private void showNumeros(){
		for (int numero=0;numero<numeros.Count;numero++)
			Console.Write(numeros[numero]+" ");
		Console.WriteLine ();
		
		/*foreach(int numero in numeros)
			Console.Write(numero + " ");
		Console.WriteLine ();*/
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
