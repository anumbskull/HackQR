using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PowerAttendance
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReportIncident : ContentPage
	{
		public ReportIncident ()
		{
			InitializeComponent ();
		}

        async void Report_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("Anonymous Report Submitted!");
            await Navigation.PushAsync(new StudentMain());
        }
    }
}