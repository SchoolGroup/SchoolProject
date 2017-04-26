namespace OstManSysAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Problem")]
    public partial class Problem
    {
        public int ProblemID { get; set; }

        public int ApartmentID { get; set; }

        [Required]
        [StringLength(30)]
        public string Header { get; set; }

        [Required]
        [StringLength(140)]
        public string Description { get; set; }

        public virtual Apartment Apartment { get; set; }
    }
}
