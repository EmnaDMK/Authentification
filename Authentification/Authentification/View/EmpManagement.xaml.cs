using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentification.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Authentification.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmpManagement : ContentPage
	{
		public EmpManagement ()
		{
			InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new AddView());

        }
	    private void ButtonUp_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new EditView());

	    }
	    private void ButtonDel_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new EditView());

	    }
    }
}