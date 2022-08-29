using MyMauiApp.Data;
using SQLite;
using Microsoft.Maui.Storage;
using MyMauiApp.Views;

namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
       
        
	}
    [Obsolete]
    private void Btn_Clicked(object sender, EventArgs e)
	{
        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
        var db = new SQLiteConnection(dbpath);

        var myquery = db.Table<RegisterTable>().Where(u => u.Email.Equals(NameTextBox.Text) && u.Password.Equals(PasswordTextBox.Text)).FirstOrDefault();

        if (myquery != null)
        {
            Preferences.Default.Set("Name", NameTextBox.Text);
            Navigation.PushAsync(new Menu());
        }
        else
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Error", "Failed Username and Password", "yes", "cancel");
                if (result)
                {
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await Navigation.PushAsync(new MainPage());
                }
            });
        }

    }
    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignUp());

    }
   

}

