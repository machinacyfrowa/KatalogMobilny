namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	public NewProductPage()
	{
		InitializeComponent();
	}

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
		EtykietaWyniku.Text = "Dodano nowy produkt";
    }
}