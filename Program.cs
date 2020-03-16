using Session107_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    class Program
    {
        public static List<IPhone> phoneList = new List<IPhone>();

        static void Main(string[] args)
        {
            Android android = new Android();
            android.Name = "Moto G4";
            android.phoneNumber = "0760000000";
            IOS iOS = new IOS();
            iOS.Name = "Iphone 6S";
            iOS.phoneNumber = "08222222";
            WindowsPhone windowsPhone = new WindowsPhone();
            windowsPhone.Name = "Nokia Lumia 8";
            windowsPhone.phoneNumber = "9673241900";
            WaltonFeaturePhone waltonFeaturePhone = new WaltonFeaturePhone();
            waltonFeaturePhone.Name = "Walton X";
            waltonFeaturePhone.phoneNumber = "12345676";
            AppoFeaturePhone appoFeaturePhone = new AppoFeaturePhone();
            appoFeaturePhone.Name = "Appo eXcel";
            appoFeaturePhone.phoneNumber = "3456432";
            LandPhone landPhone = new LandPhone();
            landPhone.Name = "Beetel Pro";
            landPhone.phoneNumber = "98762315";

            
            phoneList.Add(android);
            phoneList.Add(iOS);
            phoneList.Add(windowsPhone);
            phoneList.Add(waltonFeaturePhone);
            phoneList.Add(appoFeaturePhone);
            phoneList.Add(landPhone);

            


            android.DialCall("99090909", "hi", "789");
             

            android.DialCall("2342324", "how are you", "67");
            android.callLog();
           

            //caller outgoing
            //IPhone caller=null;
            //string message = null;





            //while (caller == null)
            //{
            //    Console.WriteLine("Enter the  caller subcriber number ");

            //    string callerNumber = Console.ReadLine();
            //    for (int i = 0; i <= phoneList.Count - 1; i++)
            //    {
            //        if (phoneList[i].phoneNumber == callerNumber)
            //        {
            //            caller = phoneList[i];
            //        }
            //    }
            //    if (caller == null)
            //    {
            //        Console.WriteLine("The phone number is not valid");
            //        //Console.ReadKey();
            //        //return;
            //    }
            //}
                

            
           

            ////receiver incoming
            //IPhone receiver = null;
            //while (receiver == null)
            //{
            //    Console.WriteLine("Enter the reciver number ");
            //    string receiverNumber = Console.ReadLine();
            //    for (int i = 0; i <= phoneList.Count - 1; i++)
            //    {
            //        if (phoneList[i].phoneNumber == receiverNumber)
            //        {
            //            receiver = phoneList[i];
            //        }
            //    }
            //    if (receiver == null)
            //    {
            //        Console.WriteLine("The phone number is not valid");
            //    }
            //    else if (caller == receiver)
            //    {
            //        Console.WriteLine("caller & receiver can not be same");
            //    }
            //    else
            //    {
            //        Console.WriteLine(caller.Name + " going to call " + receiver.Name);
            //        Console.WriteLine("Please enter " + caller.Name + "'s message :");
            //        string callerMessage = Console.ReadLine();
            //        Console.WriteLine("Enter call duration (in second) : ");
            //        string timeDuration = Console.ReadLine();
            //        message = caller.DialCall(receiver.Name, callerMessage, timeDuration);
            //        Console.WriteLine(caller.Name + " is calling " + message);
            //        string outgoingCaller = caller.Name;
            //        //Tom is about to call Jerry
            //        //Please enter Tom's message: Hi Jerry, may we meet this weekend?
            //        //Enter call duration (in seconds) :  378

            //        //caller.dial(receiver,"Hi how are you?",315);
                    
                    Console.ReadKey();

                }


            }





            //output: 
            //Nazmul called Hasina for 315 seconds telling:
            //Hi how are you dear Aunty!



            /*  Console.WriteLine("Which phone do ypu want to make a call ");
              string phoneName = Console.ReadLine();
              for(int i = 0; i <= phoneList.Count - 1; i++)
              {
                  if (phoneList[i].Name == phoneName)
                  {
                      phoneList[i].dialCall("01716664362");
                  }
              }*/

            //ask the user for this preference

            /*
            //Console.WriteLine("Please enter a number :");
            Random rand = new Random();
            int index = rand.Next(6);
            // int index =  Console.ReadLine();

            IPhone phone = phoneList[index];
            phone.dialCall("0134567");

            if (phone is ISmartPhone)
            {
                ((ISmartPhone)phone).gPS();
            }



            //if(phone is Android)
            //{
            //    ((Android)phone).gPS();
            //}


    */


            //list.Add(android);
            //list.Add(iOS);
            //list.Add(windowsPhone);



        
        //public 
    }
    

    

    

    

   

    

   
    
    class WindowsPhone : ISmartPhone
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
            return "window";
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
    }

