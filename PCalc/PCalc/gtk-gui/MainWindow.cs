
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Entry entry1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Entry entryResult;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button buttonDivision;
	private global::Gtk.Button buttonMultiplicacion;
	private global::Gtk.Button buttonSumar;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.vbox1.Add (this.entry1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.vbox1.Add (this.entry2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entryResult = new global::Gtk.Entry ();
		this.entryResult.CanFocus = true;
		this.entryResult.Name = "entryResult";
		this.entryResult.IsEditable = true;
		this.entryResult.InvisibleChar = '•';
		this.vbox1.Add (this.entryResult);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entryResult]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonDivision = new global::Gtk.Button ();
		this.buttonDivision.CanFocus = true;
		this.buttonDivision.Name = "buttonDivision";
		this.buttonDivision.UseUnderline = true;
		this.buttonDivision.Label = global::Mono.Unix.Catalog.GetString ("/");
		this.hbox1.Add (this.buttonDivision);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonDivision]));
		w4.Position = 0;
		w4.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonMultiplicacion = new global::Gtk.Button ();
		this.buttonMultiplicacion.CanFocus = true;
		this.buttonMultiplicacion.Name = "buttonMultiplicacion";
		this.buttonMultiplicacion.UseUnderline = true;
		this.buttonMultiplicacion.Label = global::Mono.Unix.Catalog.GetString ("*");
		this.hbox1.Add (this.buttonMultiplicacion);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonMultiplicacion]));
		w5.Position = 1;
		w5.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonSumar = new global::Gtk.Button ();
		this.buttonSumar.CanFocus = true;
		this.buttonSumar.Name = "buttonSumar";
		this.buttonSumar.UseUnderline = true;
		this.buttonSumar.Label = global::Mono.Unix.Catalog.GetString ("+");
		this.hbox1.Add (this.buttonSumar);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSumar]));
		w6.PackType = ((global::Gtk.PackType)(1));
		w6.Position = 2;
		w6.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w7.Position = 3;
		w7.Expand = false;
		w7.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 162;
		this.DefaultHeight = 202;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
