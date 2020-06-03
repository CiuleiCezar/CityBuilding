using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View1
{
    public class Request
    {
        public string message;
        public string body;

        public Request(string message, string body)
        {
            this.message = message;
            this.body = body;
        }

        public Request(){
        
        }
    }
}
