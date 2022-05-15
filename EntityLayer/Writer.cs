using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }

        public string WriterFullName { get { return WriterName + " " + WriterSurname; } }

        [StringLength(100)]
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        [StringLength(200)]
        public string WriterMail { get; set; }
        [StringLength(200)]
        public string WriterPassword { get; set; }
        [StringLength(50)]
        public string WritterJob { get; set; }
        public bool WriterStatus { get; set; }




        public List<Heading> Headings { get; set; }
        public List<Content> Contents { get; set; }
    }
}
