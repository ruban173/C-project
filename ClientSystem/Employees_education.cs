//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees_education
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees_education()
        {
            this.Employees = new HashSet<Employees>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_employees { get; set; }
        public string type { get; set; }
        public string organization { get; set; }
        public Nullable<System.DateTime> date_create { get; set; }
        public Nullable<int> number { get; set; }
        public string qualification { get; set; }
        public string specialty { get; set; }
        public Nullable<System.DateTime> date_up { get; set; }
        public Nullable<int> subsidiary_companies_region_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
