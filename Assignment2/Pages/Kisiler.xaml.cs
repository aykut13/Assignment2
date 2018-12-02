using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW2.Pages

{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kisiler : ContentPage
	{
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;
        public Kisiler ()
		{
			InitializeComponent ();
      /*     StackLayout panel = new StackLayout
            {
                Spacing = 15
            };
            panel.Children.Add(callButton = new Button
            {
                Text = "CALL",
                IsEnabled = false,
            });

            callButton.Clicked += OnCall;
            this.Content = panel;
        }
        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call Ahmet Arslan ?",
                "Yes",
                "No"))
            {
              //  var dialer = DependencyService.Get<IDialer>();
             //   if (dialer != null)
              //  {
             //       await dialer.DialAsync(translatedNumber);
                }*/
            
        }
    }
}
