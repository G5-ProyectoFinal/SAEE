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
    
    public partial class CourseReport
    {
        public int id { get; set; }
        public int courseId { get; set; }
        public int studentId { get; set; }
        public int proceedingId { get; set; }
        public double finalScore { get; set; }
        public string performanceDescription { get; set; }
    
        public virtual Proceedings Proceedings { get; set; }
        public virtual Users Users { get; set; }
    }
}
