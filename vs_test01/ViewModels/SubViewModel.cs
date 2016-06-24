using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace vs_test01.ViewModels
{
    public class SubViewModel : INotifyPropertyChanged
    {

        public string DBName { get; set; }
        public string SchemaName { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
