using MattEland.RoguelikeRL.ViewModels;

namespace MattEland.RoguelikeRL.Client;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		this.BindingContext = new GameViewModel();
    }
}

