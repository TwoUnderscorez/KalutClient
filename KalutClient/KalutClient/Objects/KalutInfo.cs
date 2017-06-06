using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalutClient.Objects
{
    public class KalutInfo
    {
        public string UID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Timeout { get; set; }
        public KalutInfo(string uid,string name, string desc, string timeout)
        {
            UID = uid;
            Name = name;
            Description = desc;
            Timeout = timeout;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
