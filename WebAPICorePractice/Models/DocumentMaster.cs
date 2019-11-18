using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICorePractice.Models
{
    public class DocumentMaster
    {
        public int document_id { get; set; }

        public string document_name { get; set; }
        public string document_status { get; set; }
        public string document_description { get; set; }
        public string CreatedBy { get; set; }
        public string GroupName { get; set; }
        public DateTime created_date { get; set; }
    }
}
