using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicator
{
    public class StandartResponse
    {
        public string Status { get; set; }
        public Dictionary<string,string> Data { get; set; }
        public string ErrMsg { get; set; }
    }
}
