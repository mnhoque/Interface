using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session107_Interface
{
    interface ISmartPhone : IMobile
    {
        void largeScreenDispy();
        void gPS();
        void createDocuments(string appName, string documentName);
        void shareDocument(string appName, string documentName, string contactId);
        void installApp(string appName);
    }
}
