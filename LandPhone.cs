using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    class LandPhone : IPhone
    {
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public string subscriberName { get; set; }
        string IPhone.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPhone.phoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPhone.subscriberName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void dialCall(string subscriberNumber)
        {
            Console.WriteLine("Calling from landline to the " + subscriberNumber);
        }

        public string DialCall(string subscriberNumber, string greetings, string callDuration)
        {
            return "fhfjhfh";
        }

        public string receiveCall()
        {
            Random rand = new Random();
            Console.WriteLine("Receiver receive the call from land");
            return rand.Next(99000000, 999999999).ToString();
        }

        string IPhone.callLog()
        {
            throw new NotImplementedException();
        }

        string IPhone.DialCall(string subscriberName, string greetings, string callDuration)
        {
            throw new NotImplementedException();
        }

        string IPhone.receiveCall()
        {
            throw new NotImplementedException();
        }
    }
}
