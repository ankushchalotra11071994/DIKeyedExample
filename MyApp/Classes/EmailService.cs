using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Interfaces;

namespace MyApp.Classes
{
    public class EmailService : INotification
    {
        public string SendMessage()
        {
             return "Email has been sent";
        }
    }
}