using System.Collections.Generic;

namespace vs_test01.Models
{
    public class TableModel
    {
        public static readonly int ModeNone = 0;
        public static readonly int ModeCount = 1;
        public static readonly int ModePK = 2;
        public static readonly int ModeAll = 3;

        public static readonly int CheckTypeRAW = 0;
        public static readonly int CheckTypeHASH = 1;

        //public static readonly Dictionary<int, string> ModeList
        //    = new Dictionary<int, string>()
        //{
        //    { ModeCount, "件数のみ"},
        //    { ModePK   , "PK項目"  },
        //    { ModeAll  , "全カラム"}
        //};

        //public static readonly Dictionary<int, string> CheckTypeList
        //    = new Dictionary<int, string>()
        //{
        //    { CheckTypeRAW , "RAWデータ"},
        //    { CheckTypeHASH, "HASH値"   }
        //};

        public string TableName { get; set; }
        public ModeList Mode { get; set; }
        public CheckTypeList CheckType { get; set; }
    }
    public enum ModeList
    {
        対象外,
        件数のみ,
        PK項目,
        全カラム
    };
    public enum CheckTypeList
    {
        RAWデータ,
        HASH値
    };
}
