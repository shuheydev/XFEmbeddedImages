using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFEmbeddedImages.Extensions
{
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }
    }

    public class ImageSourceConverter : IMarkupExtension, IValueConverter
    {
        //Source→View
        //ViewModelやコードビハインドからXaml側へ
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string embeddedResourcePath = (string)value;

            var imageSource = ImageSource.FromResource(embeddedResourcePath, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }

        //View→Source
        //Xaml側からViewModelやコードビハインドへ
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
