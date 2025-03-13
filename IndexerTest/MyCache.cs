//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////  인덱서(Indexer) : 클래스 내부의 데이터에 배열 형태로 접근할 수 있게 해주는 기능
////  인덱서는 클래스 내부의 데이터에 배열 형태로 접근할 수 있게 해주는 기능
//namespace IndexerTest
//{
//    public class MyCache
//    {
//        //  Dictionary : Key => Value
//        private Dictionary<string, string> _cache;

//        public MyCache()
//        {
//            _cache = new Dictionary<string, string>();

//            //Default Cache Values
//            _cache.Add("Debug", "false");
//            _cache.Add("Logging", "true");
//        }

//        public void Add(string key, string value)
//        {
//            if (!_cache.ContainsKey(key))
//            {
//                _cache[key] = value;
//            }
//            else
//            {
//                throw new ApplicationException("This key already exists in the cache");
//            }
//        }

//        private DateTime _cacheExpires;

//        //  property : CacheExpires. parameter 없이 CacheExpires를 가져올 수 있음
//        public DateTime CacheExpires
//        {
//            get { return _cacheExpires; }
//            set { _cacheExpires = value; }
//        }

//        //  Indexer : Cache의 Key를 인덱스로 사용 (Property : 속성대신 사용 가능)
//        public string this[string key]
//        {
//            get
//            {
//                //switch (key)
//                //{
//                //    default:
//                //        break;
//                //}
//                if (_cache.ContainsKey(key))
//                {
//                    return _cache[key];
//                }
//                return null;
//            }
//            set
//            {
//                if (_cache.ContainsKey(key))
//                {
//                    _cache[key] = value;
//                }
//                else
//                {
//                    throw new ApplicationException("This key does not found");
//                }
//            }
//        }

//        //  Cache에서 필요한 Get Method
//        public string Get(string key)
//        {
//            if (_cache.ContainsKey(key))
//            {
//                return _cache[key];
//            }
//            return null;
//        }

//        //  Set Method : Cache의 값 업데이트할 때 사용
//        public void Set(string key, string value)
//        {
//            if (_cache.ContainsKey(key))
//            {
//                _cache[key] = value;
//            }
//            else
//            {
//                throw new ApplicationException("This key does not found");
//            }
//        }
//        //  ... other Methods ...
//    }
//}
