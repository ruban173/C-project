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
    
    public partial class Subsidiary_companies_region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subsidiary_companies_region()
        {
            this.Goods = new HashSet<Goods>();
            this.Sale = new HashSet<Sale>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_subsidiary_companies { get; set; }
        public string city { get; set; }
        public string adress { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods> Goods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sale { get; set; }
        public virtual Subsidiary_companies Subsidiary_companies { get; set; }
    }
}
