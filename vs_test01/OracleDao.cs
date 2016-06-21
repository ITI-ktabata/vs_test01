using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace vs_test01
{
    public class OracleDao
    {
        public static string hogehoge ()
        {
            string str_cnt = "";
            using(var Connection = new OracleConnection()){
                //Data SourceにApp.configの設定を参照することができます。
                Connection.ConnectionString = ConfigurationManager.ConnectionStrings["oraattusrc02"].ConnectionString;
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
        public static object hogehoge2()
        {
            string str_cnt = "";
            List<dynamic> hoge;
            using (var Connection = new OracleConnection())
            {
                //Data SourceにApp.configの設定を参照することができます。
                Connection.ConnectionString = ConfigurationManager.ConnectionStrings["oraattusrc01"].ConnectionString;
                Connection.Open();

                //
                //接続した後はこれまでのODP.NETと同じ操作を行えます。
                //Managed Driverとの機能差については以下のURLを参照。
                //http://docs.oracle.com/cd/E57425_01/121/ODPNT/intro004.htm#CEGEJIFD
                //
                //ちなみにDapperも使えます。
                hoge = Connection.Query("SELECT GRADE,LOSAL,HISAL cnt FROM salgrade").ToList();
                str_cnt = ((Decimal)hoge[0].CNT).ToString();
            }
            //Console.ReadLine();
            return hoge;
        }
    }
}
