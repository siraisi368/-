using System;

namespace WindowsFormsApp1
{
    class NIED
    {
        public result result { get; set; }
        public string report_time { get; set; }
        public string region_code { get; set; }
        public string request_time { get; set; }
        public string region_name { get; set; }
        public string longitude { get; set; }
        public String is_cancel { get; set; }
        public string depth { get; set; }
        public string calcintensity { get; set; }
        public String is_final { get; set; }
        public String is_training { get; set; }
        public string latitude { get; set; }
        public string origin_time { get; set; }
        public security secutiry { get; set; }
        public string magunitude { get; set; }
        public string report_num { get; set; }
        public string request_hypo_type { get; set; }
        public string report_id { get; set; }
        public string alertflg { get; set; }
    }
    public class result
    {
        public string status { get; set; }
        public string message { get; set; }
        public string is_auth { get; set; }
    }
    public class security
    {
        public string realm { get; set; }
        public string hash { get; set; }
    }
}
