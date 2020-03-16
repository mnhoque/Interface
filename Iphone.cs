using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    interface IPhone
    {
        string DialCall(string subscriberName, string greetings, string callDuration);
        string receiveCall();
        string callLog();
        string Name { get; set; }
        string phoneNumber { get; set; }
        string subscriberName { get; set; }
    }
}
