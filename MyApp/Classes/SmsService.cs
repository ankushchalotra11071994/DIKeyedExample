using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Interfaces;

namespace MyApp.Classes
{
    public class SmsService : INotification
    {
        public string SendMessage()
        {
            return "Messgae has been sent";
        }
    }
}