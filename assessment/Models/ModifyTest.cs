//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace assessment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModifyTest
    {
        public int Id { get; set; }
        public int AdministratorId { get; set; }
        public int TestId { get; set; }
        public string Date { get; set; }
    
        public virtual Administrator Administrator { get; set; }
        public virtual Test Test { get; set; }
    }
}
