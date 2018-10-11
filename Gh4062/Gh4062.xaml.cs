using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Akihiko.Xamarin.Forms.Xaml.Issues.Gh4062
{
    public class Generic<T>
    {
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Component
    {
        public Generic<int> Property { get; set; }
    }
}
