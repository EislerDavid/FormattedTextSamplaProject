using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormattedTextSamplaProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            var fs = new FormattedString();
            fs.Spans.Add(new Span { Text = "All Androids: ", FontAttributes = FontAttributes.Bold });
            fs.Spans.Add(new Span { Text = "When I add some new lines, it will stuck on all Androids." + Environment.NewLine + "Do sou see?" });
            this.CrashingLabel.FormattedText = fs;
        }
    }
}
