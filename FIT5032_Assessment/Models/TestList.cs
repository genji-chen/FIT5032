namespace FIT5032_Assessment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TestList
    {
        public int Id { get; set; }

        [Required]
        public string state { get; set; }

        public int UserId { get; set; }

        public int TestId { get; set; }

        public virtual Test Test { get; set; }

        public virtual User User { get; set; }
    }
}
