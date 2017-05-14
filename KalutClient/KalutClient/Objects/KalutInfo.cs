using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalutClient.Objects
{
    class KalutInfo
    {
        public int UID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public KalutInfo(int uid,string name, string desc)
        {
            UID = uid;
            Name = name;
            Description = desc;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
