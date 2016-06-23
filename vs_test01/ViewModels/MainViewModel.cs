using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace vs_test01.ViewModels
{
    using System.Collections.Generic;
    using vs_test01.Models;
    using vs_test01.Dao;

    public class MainViewModel : INotifyPropertyChanged
    {
        public List<DBModel> DBList { get; set; }
        public List<SchemaModel> SchemaList { get; set; }
        public List<TableModel> TableList { get; set; }

        public List<DBModel> TGTDBList { get; set; }
        public List<SchemaModel> TGTSchemaList { get; set; }

        public MainViewModel()
        {
            this.DBList = GetDBNameModel.getDBName();
            this.TGTDBList = DBList;
        }

        private int _gridDBItemSelectIndex;
        public int GridDBItemSelectIndex
        {
            get
            {
                return _gridDBItemSelectIndex;
            }
            set
            {
                _gridDBItemSelectIndex = value;
                if (value >= 0)
                {
                    TableList = new List<TableModel>();
                    SchemaList = OracleDao.GetUserName(DBList[value].DBName);
                }
                NotifyPropertyChanged("GridDBItemSelectIndex");
                NotifyPropertyChanged("SchemaList"); ;
                NotifyPropertyChanged("TableList");
            }
        }

        private int _gridTGTDBItemSelectIndex;
        public int GridTGTDBItemSelectIndex
        {
            get
            {
                return _gridTGTDBItemSelectIndex;
            }
            set
            {
                _gridTGTDBItemSelectIndex = value;
                if (value >= 0)
                {
                    TGTSchemaList = OracleDao.GetUserName(TGTDBList[value].DBName);
                }
                NotifyPropertyChanged("GridTGTDBItemSelectIndex");
                NotifyPropertyChanged("TGTSchemaList"); ;
            }
        }

        private int _gridUserItemSelectIndex;
        public int GridUserItemSelectIndex
        {
            get
            {
                return _gridUserItemSelectIndex;
            }
            set
            {
                _gridUserItemSelectIndex = value;
                if (value >= 0)
                {
                    TableList = OracleDao.GetTableName(
                        DBList[_gridDBItemSelectIndex].DBName,
                        SchemaList[value].SchemaName);
                }
                NotifyPropertyChanged("GridUserItemSelectIndex");
                NotifyPropertyChanged("TableList");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}