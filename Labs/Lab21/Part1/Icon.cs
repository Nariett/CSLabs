using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    [Serializable]
    public class Icon
    {
        public string name { get; set; }
        public string user { get; set; }
        public DateTime date { get; set; }
        public string path { get; set; }
        public Icon(string name,DateTime date, string path, string position)
        {
            this.name = name;
            this.date = date;
            this.path = path;
            this.user = position;
        }
        public Icon() { }
    }
}
