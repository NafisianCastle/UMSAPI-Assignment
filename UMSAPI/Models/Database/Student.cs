//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMSAPI.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.StudentsCourses = new HashSet<StudentsCours>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<StudentsCours> StudentsCourses { get; set; }
    }
}
