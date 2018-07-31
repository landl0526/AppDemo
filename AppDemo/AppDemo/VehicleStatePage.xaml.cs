using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VehicleStatePage : ContentPage
	{
		public VehicleStatePage ()
		{
			InitializeComponent ();
		}

        public VehicleStatePage(VehicleStatePageModel model)
        {
            InitializeComponent();

            BindingContext = model;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            VehicleStatePageModel model = BindingContext as VehicleStatePageModel;
            var page = new TiresPage(model.Tires);

            Navigation.PushAsync(page);
        }
    }
}