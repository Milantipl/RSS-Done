using System;

namespace ConnectionLibrary.Model
{
    public class DocChild
    {
        public int docid { get; set; }
        public int did { get; set; }
        public string docname { get; set; }
        public string docpath { get; set; }
        public string doctype { get; set; }
        public DateTime uploded_date { get; set; }

        public int isactive { get; set; }
    }
}