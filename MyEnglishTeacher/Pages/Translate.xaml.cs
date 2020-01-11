using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.IO;
using System.Text;

namespace MyEnglishTeacher.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Translate : ContentPage
    {
        public Translate()
        {
            InitializeComponent();
        }
        private void myButton_Clicked(object sender, EventArgs e)
        {
            string encodedText = WebUtility.UrlEncode(myEntry.Text);

            var url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl="
            + "eng" + "&tl=" + "tr" + "&dt=t&q=" + encodedText;


            var request = WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string responseData = readStream.ReadToEnd();
            string result = responseData.Split('"')[1];
            btnLabel.Text = result;



        }
    }
}