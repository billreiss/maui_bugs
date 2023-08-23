namespace Maui8App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void CounterBtn_Clicked(object sender, EventArgs e)
		{
			try
			{
				var client = new ServiceReference1.Service1Client(ServiceReference1.Service1Client.EndpointConfiguration.BasicHttpsBinding_IService1);
				var result = await client.GetDataAsync(1);
				helloLabel.Text = $"Successful WCF Call. Return Value = {result}";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				helloLabel.Text = $"Error calling WCF Service. {ex.Message}";
			}
		}
	}

}
