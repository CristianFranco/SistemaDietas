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
    
    public partial class tipo_animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_animal()
        {
            this.dietas = new HashSet<dieta>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ClaveServidor { get; set; }
        public int IdNecesidad { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dieta> dietas { get; set; }
        public virtual necesidad_fisiologica necesidad_fisiologica { get; set; }
    }
}