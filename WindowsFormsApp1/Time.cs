using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class NIEDTime
    {
        public class Security
        {
            public string realm { get; set; }
            public string hash { get; set; }
        }

        public class Result
        {
            public string status { get; set; }
            public string message { get; set; }
        }

        public class Root
        {
            public Security security { get; set; }
            public string latest_time { get; set; }
            public string request_time { get; set; }
            public Result result { get; set; }
        }
    }
}
