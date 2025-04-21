namespace Front_end_MAUI;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Você clicou {count} vez";
        else
            CounterBtn.Text = $"Você clicou {count} vezes";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}