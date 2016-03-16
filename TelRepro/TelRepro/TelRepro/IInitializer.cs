using System.Collections.ObjectModel;
using TelRepro.Models;

namespace TelRepro
{
    public interface IInitializer
    {
        ObservableCollection<ActionItem> InitializeActionItems();
    }
}