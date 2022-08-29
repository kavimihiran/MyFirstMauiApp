namespace MyMauiApp.Views;

public partial class GetFertilizer : ContentPage
{
	public GetFertilizer()
	{
		InitializeComponent();
	}

	private void Btn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FertilizerScreen());
	}
}