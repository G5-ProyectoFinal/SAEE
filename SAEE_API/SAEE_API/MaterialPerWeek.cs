//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAEE_API
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialPerWeek
    {
        public int id { get; set; }
        public string name { get; set; }
        public byte[] file { get; set; }
        public string fileExtension { get; set; }
        public int weekId { get; set; }
    
        public virtual Weeks Weeks { get; set; }
    }
}