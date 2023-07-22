namespace TrackApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		CSVTranslator csv = new CSVTranslator(0, 1, @"C:\Users\rkositsky\Downloads\Test.xlsx");
		csv.ReadCSV();

		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

