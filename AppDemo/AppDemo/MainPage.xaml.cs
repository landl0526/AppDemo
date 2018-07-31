using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BindingContext = new OverviewPageModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            OverviewPageModel model = BindingContext as OverviewPageModel;
            var page = new VehicleStatePage(model.VehicleState);

            Navigation.PushAsync(page);
        }
    }
}
