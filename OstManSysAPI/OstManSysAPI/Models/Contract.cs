namespace OstManSysAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        public int ContractID { get; set; }

        public int ResidentID { get; set; }

        public int ApartmentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime MoveInDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MoveOutDate { get; set; }

        public virtual Apartment Apartment { get; set; }

        public virtual Resident Resident { get; set; }
    }
}
