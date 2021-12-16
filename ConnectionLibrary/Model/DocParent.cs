using System;
namespace ConnectionLibrary.Model
{
    public class DocParent
    {
        public int id { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string note { get; set; }
        public int userid { get; set; }
            
        public DateTime uploaded_date { get; set; }
        public string Username { get; set; }
    }
}