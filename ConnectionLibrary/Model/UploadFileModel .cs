using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConnectionLibrary.Model
{
    public class UploadFileModel
    {
        public UploadFileModel()
        {
            Files = new List<HttpPostedFileBase>();
        }

        public List<HttpPostedFileBase> Files { get; set; }

        public int docid { get; set; }
        public int did { get; set; }
        public string docname { get; set; }
        public string docpath { get; set; }
        public string doctype { get; set; }
        public DateTime uploaded_date { get; set; }
        public bool isactive { get; set; }

        public int id { get; set; }
        public string description { get; set; }
        public string note { get; set; }
        public int userid { get; set; }
        //public int docid { get; set; }


        //public string name { get; set; }
        //public string doc { get; set; }
        //public string description { get; set; }
        //public System.DateTime date { get; set; }
    }
}
