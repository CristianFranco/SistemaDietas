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
    
    public partial class dieta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dieta()
        {
            this.dieta_materia = new HashSet<dieta_materia>();
        }
    
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoAnimal { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public System.DateTime FechaExpiracion { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual tipo_animal tipo_animal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dieta_materia> dieta_materia { get; set; }
    }
}