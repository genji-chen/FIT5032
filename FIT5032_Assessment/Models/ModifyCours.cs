namespace FIT5032_Assessment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModifyCourses")]
    public partial class ModifyCours
    {
        public int Id { get; set; }

        public int AdministratorId { get; set; }

        public int CourseId { get; set; }

        public virtual Administrator Administrator { get; set; }

        public virtual Cours Cours { get; set; }
    }
}
