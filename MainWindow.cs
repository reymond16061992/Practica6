using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnFacturarClicked (object sender, EventArgs e)
	{
		double n1 = double.Parse(this.Producto1.Text);
		double n2 = double.Parse(this.Producto2.Text);
		double n3 = double.Parse(this.Producto3.Text);
		double subtotal = n1+n2+n3;
		double iva = subtotal * .16;
		double total = subtotal + iva;
		this.Subtotal.Text=subtotal.ToString();
		this.IVA.Text=iva.ToString();
		this.Total.Text=total.ToString();
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		this.Producto1.Text="";
		this.Producto2.Text="";
		this.Producto3.Text="";
		this.Subtotal.Text="";
		this.IVA.Text="";
		this.Total.Text="";
	}
}
