﻿using System;
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
        public Nullable<int> id_user_access { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string position { get; set; }
        public Nullable<int> id_subsidiary_companies_region { get; set; }
        public Nullable<int> id_education { get; set; }
        public byte[] foto { get; set; }
        public string expiriens { get; set; }
        public Nullable<System.DateTime> date_begin { get; set; }
        public System.DateTime date_up { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
    
        public virtual UserAccess UserAccess { get; set; }
	
	}

}
