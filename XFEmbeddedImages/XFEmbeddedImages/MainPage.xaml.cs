using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFEmbeddedImages
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public string ResourcePath { get; set; } = "XFEmbeddedImages.Images.avatar_men_2.jpg";
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = this;
        }
    }
}
