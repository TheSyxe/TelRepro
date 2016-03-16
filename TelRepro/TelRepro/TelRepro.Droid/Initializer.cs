using System.Collections.ObjectModel;
using TelRepro.Droid;
using TelRepro.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(Initializer))]
namespace TelRepro.Droid
{
    public class Initializer : IInitializer
    {
        public ObservableCollection<ActionItem> InitializeActionItems()
        {
            return new ObservableCollection<ActionItem>();
        }
    }
}