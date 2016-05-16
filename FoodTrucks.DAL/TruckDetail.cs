//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodTrucks.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TruckDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TruckDetail()
        {
            this.Reviews = new HashSet<Review>();
        }
    
        public int Id { get; set; }
        public string TruckName { get; set; }
        public string Description { get; set; }
        public Nullable<int> FoodTypeId { get; set; }
        public string Lattitude { get; set; }
        public Nullable<byte> IsActive { get; set; }
        public string Link { get; set; }
        public string Menu { get; set; }
        public Nullable<int> BarId { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> ModifedAt { get; set; }
        public string Longitude { get; set; }
    
        public virtual Bar Bar { get; set; }
        public virtual FoodType FoodType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual TruckDetail TruckDetail1 { get; set; }
        public virtual TruckDetail TruckDetail2 { get; set; }
    }
}