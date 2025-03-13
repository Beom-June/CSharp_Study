//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IndexerTest
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyCache _myCache = new MyCache();

//            _myCache.Add("ItemId", "1100");     //  Add Method

//            string _dbg = _myCache.Get("Debug");    //  Get Method : Debug Key의 Value를 가져옴

//            _myCache.Set("debug", "false");  //  Set Method : Debug Key의 Value를 업데이트

//            string _db = _myCache["Debug"];     //  Indexer : Debug Key의 Value를 업데이트
//            _myCache["Debug"] = "false";
//        }
//    }
//}
