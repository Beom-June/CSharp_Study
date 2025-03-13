//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net.Mail;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;

//namespace MsgAPp
//{
//    // 추상 클래스, abstract class, 인스턴스를 생성할 수 없음,  파생 클래스를 만들어서 사용해야함
//    abstract class MessageBase
//    {
//        protected Guid _id = Guid.NewGuid();
//        public string ToWhom { get; set; }
//        public string Message { get; set; }

//        public abstract void Send();       //  추상 메소드, abstract method, 파생 클래스에서 반드시 재정의 해야함
//        //public virtual void Send()
//        //{
//        //    Console.WriteLine($"Send Message To {ToWhom}:");
//        //    Console.WriteLine($"{Message}");
//        //}

//        protected void DebugMessageInfo()
//        {
//            Debug.WriteLine($"Message Id : {_id}");
//            Debug.WriteLine($"To : {ToWhom}");
//            Debug.WriteLine($"Message : {Message}");
//        }
//    }

//    // 파생 클래스, derived class
//    class EmailMessage : MessageBase
//    //sealed class EmailMessage : MessageBase -> sealed class, 상속을 막음
//    {
//        public string _Email { get; set; }

//        public EmailMessage(string email)
//        {
//            this._Email = email;
//        }

//        // 오버라이딩, overriding, base class의 메소드를 파생 클래스에서 재정의
//        public override void Send()
//        {
//            MailMessage _msg = new MailMessage("sender@live.com", this._Email, "Subject", this.Message);
//            SmtpClient _smtp = new SmtpClient("smtp.live.com", 587);
//            _smtp.EnableSsl = true;
//            _smtp.Credentials = new NetworkCredential("sender@live.com", "password");       //  받는 사람의 이메일, 패스워드
//            _smtp.Send(_msg);
//        }
//    }
//    class CompanyMessage : MessageBase
//    {
//        public string _CompanyName { get; set; }
//        public override void Send()
//        {
//            DebugMessageInfo();
//            Console.WriteLine($"Send Message To {_CompanyName}:");
//            Console.WriteLine($"{Message}");
//        }
//    }
//    class SMSMessage : MessageBase
//    {
//        public string _phoneNumber { get; set; }

//        public override void Send()
//        {
//            //  TwilioClient : 웹서비스
//            //TwilioClient.Init("accountSid", "authToken");
//            //var message = MessageResource.Create(
//            //    body: this.Message,
//            //    from: new Twilio.Types.PhoneNumber("+12345678901"),
//            //    to: new Twilio.Types.PhoneNumber(this._phoneNumber)
//            //);
//        }
//    }

//    // ....
//}
