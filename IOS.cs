using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    
        class IOS : ISmartPhone
        {
            public string Name { get; set; }
            public string phoneNumber { get; set; }
            public string subscriberName { get; set; }
            string IPhone.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            string IPhone.phoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            string IPhone.subscriberName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public bool bluetooth(bool status)
            {
                throw new NotImplementedException();
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
                return "Iphone";
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

            bool IMobile.bluetooth(bool status)
            {
                throw new NotImplementedException();
            }

            string IPhone.callLog()
            {
                throw new NotImplementedException();
            }

            void ISmartPhone.createDocuments(string appName, string documentName)
            {
                throw new NotImplementedException();
            }

            string IPhone.DialCall(string subscriberName, string greetings, string callDuration)
            {
                throw new NotImplementedException();
            }

            void IMobile.display()
            {
                throw new NotImplementedException();
            }

            void ISmartPhone.gPS()
            {
                throw new NotImplementedException();
            }

            void ISmartPhone.installApp(string appName)
            {
                throw new NotImplementedException();
            }

            void ISmartPhone.largeScreenDispy()
            {
                throw new NotImplementedException();
            }

            string IMobile.playMusic()
            {
                throw new NotImplementedException();
            }

            string IPhone.receiveCall()
            {
                throw new NotImplementedException();
            }

            void IMobile.sendMessage(string subscribersNumber, string message)
            {
                throw new NotImplementedException();
            }

            void ISmartPhone.shareDocument(string appName, string documentName, string contactId)
            {
                throw new NotImplementedException();
            }

            void IMobile.tuneChannelInRadio(int frequency)
            {
                throw new NotImplementedException();
            }
        }

    }

