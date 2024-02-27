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
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.ActionReport = new HashSet<ActionReport>();
            this.AssignmentGrading = new HashSet<AssignmentGrading>();
            this.CourseReport = new HashSet<CourseReport>();
            this.EnrolledCourses = new HashSet<EnrolledCourses>();
            this.ErrorReport = new HashSet<ErrorReport>();
            this.Proceedings = new HashSet<Proceedings>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public System.DateTime birthdate { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        public byte[] profilePicture { get; set; }
        public int userType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionReport> ActionReport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignmentGrading> AssignmentGrading { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseReport> CourseReport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrolledCourses> EnrolledCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorReport> ErrorReport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proceedings> Proceedings { get; set; }
        public virtual TeacherData TeacherData { get; set; }
        public virtual UsersTypes UsersTypes { get; set; }
    }
}
