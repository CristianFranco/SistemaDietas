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
    
    public partial class CodeNumberConfirmed
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int SessionId { get; set; }
        public System.DateTime ExpirationDate { get; set; }
    
        public virtual Session Session { get; set; }
    }
}
