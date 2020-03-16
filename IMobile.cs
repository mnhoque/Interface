using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    interface IMobile : IPhone
    {

        void display();
        void sendMessage(string subscribersNumber, string message);
        bool bluetooth(Boolean status);
        string playMusic();
        void tuneChannelInRadio(int frequency);

    }
}
