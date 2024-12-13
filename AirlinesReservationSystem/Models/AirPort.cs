namespace AirlinesReservationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AirPort")]
    public partial class AirPort
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AirPort()
        {
            FlightSchedules = new HashSet<FlightSchedule>();
            FlightSchedules1 = new HashSet<FlightSchedule>();
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [Required]
        [DisplayName("Tên")]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [DisplayName("Mã")]
        [StringLength(255)]
        public string code { get; set; }

        [Required]
        [DisplayName("Địa chỉ")]
        [StringLength(255)]
        public string address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightSchedule> FlightSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightSchedule> FlightSchedules1 { get; set; }
    }
}
