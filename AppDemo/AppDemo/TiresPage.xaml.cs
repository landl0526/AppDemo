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
	public partial class TiresPage : ContentPage
	{
		public TiresPage ()
		{
			InitializeComponent ();
		}

        public TiresPage(TiresPageModel model)
        {
            InitializeComponent();

            BindingContext = model;
        }
    }
}