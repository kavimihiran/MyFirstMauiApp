namespace MyMauiApp.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
        MyName.Text = $"Hi {Preferences.Default.Get("Name", "Unknown")}";
    }

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SelectLocationScreen());

	}

	private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
	{
		Navigation.PushAsync(new GetSolution());
	}

	private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
	{
		Navigation.PushAsync(new GetFertilizer());
	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());

	}
}