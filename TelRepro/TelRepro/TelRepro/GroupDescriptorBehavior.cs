using System.Collections;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace TelRepro
{
    public class GroupDescriptorBehavior
    {
        public static readonly BindableProperty DescriptorProperty = BindableProperty.CreateAttached<GroupDescriptorBehavior, GroupDescriptorBase>(
               bindable => GroupDescriptorBehavior.GetDescriptor(bindable),
               null,
               BindingMode.OneWay,
               null,
               (b, o, n) => GroupDescriptorBehavior.OnDescriptorChanged(b, o, n),
               null,
               null);

        public static GroupDescriptorBase GetDescriptor(BindableObject bo)
        {
            return (GroupDescriptorBase)bo.GetValue(GroupDescriptorBehavior.DescriptorProperty);
        }

        public static void SetDescriptor(BindableObject bo, GroupDescriptorBase value)
        {
            bo.SetValue(GroupDescriptorBehavior.DescriptorProperty, value);
        }

        public static void OnDescriptorChanged(BindableObject bo, GroupDescriptorBase oldValue, GroupDescriptorBase newValue)
        {
            (bo as RadListView).PropertyChanged += (o, e) => {
                var listview = o as RadListView;

                if (e.PropertyName != RadListView.ItemsSourceProperty.PropertyName)
                {
                    return;
                }

                var list = listview.ItemsSource as IList;

                if (list != null && list.Count > 0)
                {
                    var descriptor = GroupDescriptorBehavior.GetDescriptor(listview) as GroupDescriptorBase;

                    if (descriptor != null && !listview.GroupDescriptors.Contains(descriptor))
                    {
                        listview.GroupDescriptors.Add(descriptor);
                    }
                }
                else
                {
                    var descriptor = GroupDescriptorBehavior.GetDescriptor(listview) as GroupDescriptorBase;

                    if (descriptor != null)
                    {
                        listview.GroupDescriptors.Remove(descriptor);
                    }
                }
            };
        }
    }
}