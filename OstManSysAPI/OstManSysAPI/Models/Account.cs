namespace OstManSysAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int AccountID { get; set; }

        public int ResidentID { get; set; }

        public int Password { get; set; }

        public virtual Resident Resident { get; set; }
    }
}
