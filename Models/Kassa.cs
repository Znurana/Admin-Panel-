using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models
{
    public class Kassa
    {
        public int KassaID { get; set; }
        public string KassaIP { get; set; }
        public string KassaNumber { get; set; }
        public string MonitorIP { get; set; }
        public string KompIP { get; set; }
        public User user { get; set; }

    }
}
