//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace agregaUsuario.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banner()
        {
            this.BannerShow = new HashSet<BannerShow>();
        }
    
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string RedirectURL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BannerShow> BannerShow { get; set; }
    }
}
