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
    public partial class StudentMain : ContentPage
    {
        public StudentMain()
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            //Test to show how to update element on page
            Title.Text = "Harry Potter";
        }

        async void QRCode_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QRPage());
        }

        async void Report_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportIncident());
        }

        async void PhoneNumber_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpfulNumbers());
        }

        async void Emergency_Clicked(object sender, EventArgs e)
        {

        }

        async void BuildingMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuildingMap());
        }
    }
}