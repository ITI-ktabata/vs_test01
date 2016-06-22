using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Input;
using System.Threading.Tasks;

namespace vs_test01.ViewModels
{
    using System.Collections.Generic;
    using vs_test01.Models;
    using vs_test01.Dao;

    public class MainViewModel : INotifyPropertyChanged
    {
        public List<DBModel> DBList { get; set; }
        public List<SchemaModel> SchemaList { get; set; }

        public MainViewModel()
        {
            this.DBList = GetDBNameModel.getDBName();
        }

        private int _gridItemSelectIndex;
        public int GridItemSelectIndex
        {
            get
            {
                return _gridItemSelectIndex;
            }
            set
            {
                _gridItemSelectIndex = value;
                if (value >= 0)
                {
                    SchemaList = OracleDao.hogehoge(DBList[value].DBName);
                }
                NotifyPropertyChanged("GridItemSelectIndex");
                NotifyPropertyChanged("SchemaList");
            }
        }
        public List<SchemaModel> GridSchemaItem
        {
            get
            {
                return SchemaList;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}