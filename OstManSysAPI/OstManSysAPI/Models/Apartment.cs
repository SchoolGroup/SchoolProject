namespace OstManSysAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apartment")]
    public partial class Apartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apartment()
        {
            Contracts = new HashSet<Contract>();
            Problems = new HashSet<Problem>();
        }

        public int ApartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public int Size { get; set; }

        public int NumberOfRooms { get; set; }

        [Column(TypeName = "money")]
        public decimal MonthlyRent { get; set; }

        [Required]
        [StringLength(250)]
        public string Condition { get; set; }

        public bool IsRented { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Problem> Problems { get; set; }
    }
}
