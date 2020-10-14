using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Helper    
{
    [ContentProperty(nameof(Source))]
    public class ImageHelper : IMarkupExtension
    {

        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            var imgSource = ImageSource.FromResource(Source, typeof(ImageHelper).GetTypeInfo().Assembly);
            return imgSource;
        }
    }
}
