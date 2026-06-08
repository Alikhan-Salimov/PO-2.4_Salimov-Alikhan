namespace SchoolApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnStatusButtonClicked(object? sender, EventArgs e)
	{
		StatusLabel.Text = "Status: all lessons completed";
		SemanticScreenReader.Announce(StatusLabel.Text);
	}
}
