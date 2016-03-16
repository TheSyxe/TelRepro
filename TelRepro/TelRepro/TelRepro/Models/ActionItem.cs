using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TelRepro.Models
{
    public partial class ActionItem : INotifyPropertyChanged
    {
        public ActionItemType ActionType { get; set; }
        public string ActionTypeStr
        {
            get
            {
                var actionItem = ActionType.ToString();
                return actionItem;
            }
        }
        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value == _isSelected) return;
                _isSelected = value;
                IsNotSelected = !value;
                OnPropertyChanged();
            }
        }
        private bool _isNotSelected;
        public bool IsNotSelected
        {
            get { return _isNotSelected; }
            private set
            {
                _isNotSelected = value;
                OnPropertyChanged();
            }
        }
        public string Description { get; set; }
        private string _property;
        public string Property
        {
            get { return _property; }
            set
            {
                if (value == _property) return;
                _property = value;
                OnPropertyChanged();
                OnPropertyChanged("PropertyStr");
            }
        }
        public string PropertyStr
        {
            get
            {
                var property = Property;
                if (string.IsNullOrWhiteSpace(property))
                    return "";
                var split = property.TrimEnd(' ').Split(' ');
                if (split.Last().StartsWith("("))
                    property = Property.Replace(split.Last(), "");
                return property;
            }
        }
        public string AcctManager { get; set; }
        public string AcctMgrPhone { get; set; }
        public string AcctMgrEmail { get; set; }
        public string PropSvcRep { get; set; }
        public string PsrPhone { get; set; }
        public string PsrEmail { get; set; }
        public string InstanceId { get; set; }
        public string LeftAction { get; set; }
        public string RightAction { get; set; }
        public bool IsUtilityAlert
        {
            get { return ActionType == ActionItemType.UtilityAlert; }
        }
        public string CreatedAt
        {
            get
            {
                return CreatedAtDt.Date.ToString().Split(' ')[0];
            }
        }
        public DateTime CreatedAtDt { get; set; }
        public Dictionary<string, object> Details { get; set; }
        #region Overrides of Object
        public override string ToString() { return string.Format("{0}-{1}", Description, InstanceId); }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged == null) return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ChangeActTypeStr()
        {
            OnPropertyChanged("ActionTypeStr");
        }
    }
}