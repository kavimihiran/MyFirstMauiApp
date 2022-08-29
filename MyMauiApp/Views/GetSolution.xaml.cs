namespace MyMauiApp.Views;

public partial class GetSolution : ContentPage
{
	public GetSolution()
	{
		InitializeComponent();
	}

	private void Btn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PestsDis());
	}
}