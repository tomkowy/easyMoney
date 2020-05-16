using System;

namespace EasyMoney.Modules.FakeNotifications.Application.SendEmail.Exceptions
{
    public class EmailWasntSentException : Exception
    {
        public EmailWasntSentException() : base("Email Wasn't Sent")
        {
        }
    }
}
