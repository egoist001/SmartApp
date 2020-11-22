using System;
using System.Net;
using System.Net.Mail;

namespace Log_Reg_Form.Core
{
    public static class AccountManager
    {
        private static readonly string _host;
        private static readonly int _port;
        private static readonly string _email;
        private static readonly string _password;
        private static readonly SmtpClient _sender;
        private static readonly string _mailSubject;


        static AccountManager()
        {
            _host = "smtp.gmail.com";
            _port = 587;
            _email = "bot.of.the.project@gmail.com";
            _password = "log&regForm";
            _mailSubject = "Confirmation Code - Log&Reg Form";
            _sender = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_email, _password),
                EnableSsl = true
            };
        }
        public static event Action DisplayConfirmationWindow;
        public static string ConfirmationCode { get; private set; }
        public static void SendMail(string recipentEmail)
        {
            _sender.Send(_email, recipentEmail, _mailSubject, GetConfirmationMail());
            DisplayConfirmationWindow();
        }
        private static string GetConfirmationMail()
        {
            return $"Hello!\nWe have sent a confirmation code!\nPlease confirm your email by entering this code - {GetConfirmationCode()}";
        }
        private static string GetConfirmationCode()
        {
            string code = new Random().Next(1000, 9999).ToString();
            ConfirmationCode = code;
            return code;
        }
    }
}
