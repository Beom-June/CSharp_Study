//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InterfaceTest
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            List<ISendable> _deliveryMethods = new List<ISendable>();
//            _deliveryMethods.Add(new Email());
//            _deliveryMethods.Add(new SnailMail());
//            _deliveryMethods.Add(new SMS());


//            Alert(_deliveryMethods, "Emergency msg...");
//        }

//        private static void Alert(List<ISendable> deliveryMethods, string msg)
//        {
//            foreach (ISendable s in deliveryMethods)
//            {
//                s.Send(msg);
//            }
//        }
//    }
//}
