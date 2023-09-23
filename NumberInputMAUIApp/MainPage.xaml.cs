namespace NumberInputMAUIApp
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void HandleButtonClicked(object sender, EventArgs e)
		{
			// Отримайте текст з Entry та обробіть його як число
			if (int.TryParse(numberEntry.Text, out int number))
			{
				// Тут ви можете виконати дії з числом
				DisplayAlert("Результат", $"Ви ввели число: {number}", "OK");
			}
			else
			{
				DisplayAlert("Помилка", "Введіть коректне число.", "OK");
			}
		}
	}
}