using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Akihiko.Xamarin.Forms.Xaml.Issues.Gh4047
{
    class MarkupExtension<T> : IMarkupExtension<T>
    {
        public T ProvideValue(IServiceProvider provider)
        {
            return default(T);
        }

        object IMarkupExtension.ProvideValue(IServiceProvider provider)
        {
            return default(T);
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Component
    {
        public byte Property { get; set; }
    }
}
