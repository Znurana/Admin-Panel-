using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models
{
    public class Station
    {
        public int StationID { get; set; }
        public string StationName { get; set; }
        public IList<User> users { get; set; }
    }
}
