using Microsoft.Maui.Controls;
using MyMauiApp.Data;
using SQLite;

namespace MyMauiApp.Views;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

    [Obsolete]
    private void Btn_Clicked_1(object sender, EventArgs e)
	{
        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");

        var db = new SQLiteConnection(dbpath);
        db.CreateTable<RegisterTable>();

        RegisterTable item = new RegisterTable();
        
        if (EntryFirstName.Text != null && EntryLastName.Text != null && EntryEmail.Text != null && EntryPassword.Text != null)
        {
            item.FirstName=EntryFirstName.Text;
            item.LastName=EntryLastName.Text;
            item.Email=EntryEmail.Text;
            item.Password=EntryPassword.Text;
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations ", "User Registered sucessfully", "yes", "cancel");

                if (result)
                {
                    await Navigation.PushAsync(new MainPage());
                }

            }
             );
        }
        else {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Failed login","please fill all the fields", "yes", "cancel");

               
            }
             );
        }
        
        
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var navigationPage = Application.Current.MainPage as NavigationPage;
        navigationPage.BarBackgroundColor = Color.FromArgb("#228B22");
       
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        var navigationPage = Application.Current.MainPage as NavigationPage;
        navigationPage.BarBackgroundColor = Color.FromArgb("#228B22");
       
    }
    


}