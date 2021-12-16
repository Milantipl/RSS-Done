using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConnectionLibrary.Model
{
    public class docmodel
    {
        public int id { get; set; }

        public string description { get; set; }

        public string note { get; set; }
        public int userid { get; set; }

        public string Username { get; set; }

        public int docid { get; set; }
        public int did { get; set; }
        public string docname { get; set; }
        public string docpath { get; set; }
        public string doctype { get; set; }
        public DateTime uploaded_date { get; set; }


        public DateTime uploded_date { get; set; }
        public int isactive { get; set; }

        public int NoOfDocuments { get; set; }
       

    }
}