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
    
    public partial class Weeks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Weeks()
        {
            this.ContentPerWeek = new HashSet<ContentPerWeek>();
            this.CourseTasks = new HashSet<CourseTasks>();
        }
    
        public int id { get; set; }
        public int weekNum { get; set; }
        public int courseAvailableId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentPerWeek> ContentPerWeek { get; set; }
        public virtual CourseAvailable CourseAvailable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTasks> CourseTasks { get; set; }
    }
}
