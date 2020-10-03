namespace FIT5032_Assessment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ModifyUser
    {
        public int Id { get; set; }

        [Required]
        public string Action { get; set; }

        [Required]
        public string Date { get; set; }

        public int UserId { get; set; }

        public int AdministratorId { get; set; }

        public virtual Administrator Administrator { get; set; }

        public virtual User User { get; set; }
    }
}
