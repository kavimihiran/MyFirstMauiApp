namespace MyMauiApp.Views;

public partial class PestsDis : ContentPage
{
	public PestsDis()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Solution1());

	}
}