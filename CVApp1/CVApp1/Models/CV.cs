using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp1.Models
{
    public class CV
    {
        public string name { get; set; }
        public DateTime Birthdate { get; set; }
        public string emailaddress { get; set; }
        public string tel { get; set; }
        public string address { get; set; }
        public string headline { get; set; }
        public List<EduQ> Education = new List<EduQ>();
        public List<Publications> Publications = new List<Publications>();
        public List<Cert> Certifications = new List<Cert>();
        public List<WorkExp> WorkExp = new List<WorkExp>();
        public string hobbies { get; set; }
    }

    public class EduQ
    {
        public string Institute { get; set; }
        public string degreetype { get; set; }
        public string degreename { get; set; }
        public DateTime fromd { get; set; }
        public DateTime tod { get; set; }
    }

    public class Cert
    {
        public string course { get; set; }
        public string company { get; set; }
        public string desc { get; set; }
        public DateTime date1 { get; set; }
    }

    public class WorkExp
    {
        public string position { get; set; }
        public string company { get; set; }
        public string caddrss { get; set; }
        public DateTime fromd { get; set; }
        public DateTime tod { get; set; }
        public string desc { get; set; }
    }

    public class Publications
    {
        public string reference { get; set; }
    }

}

