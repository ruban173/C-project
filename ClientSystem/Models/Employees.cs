using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientSystem.Models
{

    [Table("Employees")]

    class Employees
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string middle__name { get; set; }
        public string last_name { get; set; }
        public string birthday { get; set; }
        public string position { get; set; }
        public int id_subsidiary_companies_region { get; set; }
        public int id_education { get; set; }
        public byte foto { get; set; }
        public string expiriens { get; set; }
        public string date_begin { get; set; }
        public string date_end { get; set; }
        public string date_up { get; set; }  	
	
	}

}
