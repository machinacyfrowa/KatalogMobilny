namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	private int licznik = 0;
    public NewProductPage()
	{
		InitializeComponent();
	}

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
		licznik++;
		EtykietaWyniku.Text = $"Kliknięto {licznik} razy";
    }

    private void NazwaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string tekst = NazwaEntry.Text;
        int iloscZnakow = tekst.Length;
        EtykietaWyniku.Text = $"Nazwa ma {iloscZnakow} znaków";
    }
    //TODO: oprogramuj drugi guzik w taki sposób żeby resetował licznik i wyświetlał w etykiecie "Kliknięto 0 razy"
    private void Reset_Clicked(object sender, EventArgs e)
    {
        licznik = 0;
        EtykietaWyniku.Text = $"Kliknięto {licznik} razy";
    }

    private void AvailableSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        if(AvailableSwitch.IsToggled)
        {
            AvailableLabel.Text = "Produkt jest dostępny";
        }
        else
        {
            AvailableLabel.Text = "Produkt jest niedostępny";
        }
    }

    private void KategoriaPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        EtykietaWyniku.Text = $"Wybrano kategorię: {KategoriaPicker.SelectedItem}";
    }
}