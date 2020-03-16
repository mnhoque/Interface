using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    class Android : ISmartPhone
    {
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public string subscriberName { get; set; }
        public bool bluetooth(bool status)
        {
            if (status.ToString() == "on")
            {
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        public void createDocuments(string appName, string documentName)
        {
            throw new NotImplementedException();
        }

        public void dialCall(string subscriberNumber)
        {
            throw new NotImplementedException();
        }

        public string DialCall(string subscriberNumber, string greetings, string callDuration)
        {
            for(int i =0; i <= Program.phoneList.Count - 1; i++)
            {
                if (Program.phoneList[i].phoneNumber == subscriberNumber)
                {
                   
                }
            }

            return subscriberNumber + " " + greetings + " " + callDuration;
        }

        private void createCallLog(string subscriberNumber, string greetings, string callDuration)
        {
            List<Calllog> callList = new List<Calllog>();
            callList
        }

        public void display()
        {
            throw new NotImplementedException();
        }

        public void gPS()
        {
            throw new NotImplementedException();
        }

        public void installApp(string appName)
        {
            throw new NotImplementedException();
        }

        public void largeScreenDispy()
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

        public void shareDocument(string appName, string documentName, string contactId)
        {
            throw new NotImplementedException();
        }

        public void tuneChannelInRadio(int frequency)
        {
            throw new NotImplementedException();
        }

        public string dialCall(string subscriberName, string greetings, string callDuration)
        {
            return "Android";
        }

        public string callLog()
        {
            throw new NotImplementedException();
        }
    }

}
