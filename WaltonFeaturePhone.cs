using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    class WaltonFeaturePhone : IMobile
    {
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public string subscriberName { get; set; }
        public bool bluetooth(bool status)
        {
            return status;
        }

        public string callLog()
        {
            throw new NotImplementedException();
        }

        public void dialCall(string subscriberNumber)
        {
            Console.WriteLine("You are called from " + subscriberNumber);
        }

        public string DialCall(string subscriberNumber, string greetings, string callDuration)
        {
            return "walton";
        }

        public void display()
        {
            Console.WriteLine("The diaplay is coloured");
        }

        public string playMusic()
        {
            Console.WriteLine("Lets play music");
            return null;
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
