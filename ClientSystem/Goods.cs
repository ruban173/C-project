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
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.Sale_basket = new HashSet<Sale_basket>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string manufacturer { get; set; }
        public string description { get; set; }
        public Nullable<int> id_goods_category { get; set; }
        public Nullable<int> id_subsidiary_companies_region { get; set; }
        public Nullable<int> shelf_life { get; set; }
        public Nullable<System.DateTime> date_create { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<double> discont { get; set; }
        public string measurement { get; set; }
        public Nullable<int> count { get; set; }
        public string code { get; set; }
        public string basket { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale_basket> Sale_basket { get; set; }
        public virtual Goods_category Goods_category { get; set; }
        public virtual Subsidiary_companies_region Subsidiary_companies_region { get; set; }
    }
}
