using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //dll-dinamic link library
    class Main
    {
        public Main()
        {
            Notification not = new Notification();
            not.MyProperty = 15;
        }
    }
    public class Notification
    {
        protected internal int MyProperty { get; set; }
        private protected string Title;
    }

    class Sms : Notification 
    {
        public void Test()
        {
            MyProperty = 15;
            Title = "Information";
        }
    }
}
