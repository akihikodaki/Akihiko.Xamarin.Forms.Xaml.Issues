using NUnit.Framework;
using System.Collections;
using Xamarin.Forms.Xaml;

namespace Akihiko.Xamarin.Forms.Xaml.Issues.Gh4238
{
    [TestFixture]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Component
    {
        public ArrayList Property { get; set; }

        [Test]
        public void Test()
        {
            InitializeComponent();
            Assert.AreEqual(0f, Property[0]);
        }
    }
}
