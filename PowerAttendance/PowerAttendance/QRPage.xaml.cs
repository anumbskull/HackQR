using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace PowerAttendance
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QRPage : ContentPage
	{
        private ZXingBarcodeImageView barcode;

        public QRPage ()
		{
			InitializeComponent ();
            GenerateQR_Clicked(null, null);
        }

        private void GenerateQR_Clicked(object sender, EventArgs e)
        {
            barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            barcode.BarcodeFormat = BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 375;
            barcode.BarcodeOptions.Height = 375;
            barcode.WidthRequest = 375;
            barcode.HeightRequest = 375;
            barcode.BarcodeValue = "This is different information";
            qrResult.Content = barcode;
        }
    }
}