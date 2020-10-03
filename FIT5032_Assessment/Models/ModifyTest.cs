namespace FIT5032_Assessment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ModifyTest
    {
        public int Id { get; set; }

        public int AdministratorId { get; set; }

        public int TestId { get; set; }

        [Required]
        public string Date { get; set; }

        public virtual Administrator Administrator { get; set; }

        public virtual Test Test { get; set; }
    }
}
