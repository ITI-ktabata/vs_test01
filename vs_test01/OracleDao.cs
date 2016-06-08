using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace vs_test01
{
    class OracleDao
    {
        public static string hogehoge ()
        {
            string str_cnt = "";
            using(var Connection = new OracleConnection()){
                //Data SourceにApp.configの設定を参照することができます。
                Connection.ConnectionString = "User ID=scott; Password=tiger; Data Source=oraattusrc01;";
                Connection.Open();

                //
                //接続した後はこれまでのODP.NETと同じ操作を行えます。
                //Managed Driverとの機能差については以下のURLを参照。
                //http://docs.oracle.com/cd/E57425_01/121/ODPNT/intro004.htm#CEGEJIFD
                //
                //ちなみにDapperも使えます。
                List<dynamic> hoge =  Connection.Query("SELECT count(1) as cnt FROM salgrade").ToList();
                str_cnt = ((Decimal)hoge[0].CNT).ToString();
            }
            Console.ReadLine();
            return str_cnt;
        }
    }
}
