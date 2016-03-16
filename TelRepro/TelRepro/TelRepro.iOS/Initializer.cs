using System.Collections.Generic;
using System.Collections.ObjectModel;
using TelRepro.iOS;
using TelRepro.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(Initializer))]
namespace TelRepro.iOS
{
    public class Initializer : IInitializer
    {
        public ObservableCollection<ActionItem> InitializeActionItems()
        {
            var list = new List<ActionItem>
            {
                new ActionItem
                {
                    ActionType = ActionItemType.PrebillingApproval,
                    Description = "Dummy",
                    Property = "",
                    AcctManager = "",
                    AcctMgrPhone = "",
                    AcctMgrEmail = "",
                    PropSvcRep = "",
                    PsrPhone = "",
                    PsrEmail = "",
                    InstanceId = "",
                    CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                    Details = new Dictionary<string, object>()
                }
            };
            return new ObservableCollection<ActionItem>(list);
        }
    }
}
