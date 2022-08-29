namespace MyMauiApp.Views;

public partial class SelectLocationScreen : ContentPage
{
	public SelectLocationScreen()
	{
		InitializeComponent();
	}

	private void Btn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new RecommendedCrops());

	}
}