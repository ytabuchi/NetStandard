using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFNetStandard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var translatedText = await NetStandardLibrary.TranslateLib.TranslateTextAsync(entry.Text) ?? "Nothing";
            label.Text = translatedText;
        }
    }
}
