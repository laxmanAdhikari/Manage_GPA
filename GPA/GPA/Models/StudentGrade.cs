//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GPA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentGrade
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int GradeId { get; set; }
        public bool Status { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Grade Grade { get; set; }
    }
}