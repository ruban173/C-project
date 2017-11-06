using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientSystem.Models
{

    [Table("User_access")]

    class UserAccess
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public string date_up { get; set; }
        public int id_subsidiary_companies_region { get; set; }
        public string status { get; set; }



    }

}
