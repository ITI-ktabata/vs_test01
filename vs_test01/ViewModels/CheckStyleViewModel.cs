using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace vs_test01.ViewModels
{
    using System.Collections.Generic;
    public class CheckStyleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            field = value;
            var h = this.PropertyChanged;
            if (h != null) { h(this, new PropertyChangedEventArgs(propertyName)); }
        }
    }
}
