using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    class AppoFeaturePhone : IMobile
    {
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public string subscriberName { get; set; }
        public bool bluetooth(bool status)
        {
            throw new NotImplementedException();
        }

        public string callLog()
        {
            throw new NotImplementedException();
        }

        public void dialCall(string subscriberNumber)
        {
            throw new NotImplementedException();
        }

        public string DialCall(string subscriberNumber, string greetings, string callDuration)
        {
            return "appoPhone";
        }

        public void display()
        {
            throw new NotImplementedException();
        }

        public string playMusic()
        {
            throw new NotImplementedException();
        }

        public string receiveCall()
        {
            throw new NotImplementedException();
        }

        public void sendMessage(string subscribersNumber, string message)
        {
            throw new NotImplementedException();
        }

        public void tuneChannelInRadio(int frequency)
        {
            throw new NotImplementedException();
        }
    }
}
