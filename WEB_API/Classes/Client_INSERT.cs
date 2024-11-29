using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API.Classes
{
    public class Client_INSERT
    {
        public string NAME { get; set; }
        public string SNAME { get; set; }
        public int PHONE { get; set; }
        public string ADRESS { get; set; }
        public int ZIPCODE { get; set; }
        public string MAIL { get; set; }
        public string MESSAGE { get; set; }
        public double LATITUDE { get; set; }
        public double LONGITUDE { get; set; }
    }
}