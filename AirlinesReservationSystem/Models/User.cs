namespace AirlinesReservationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("User")]
    public partial class User
    {
        private static Model1 db = new Model1();
        public const  int TYPE_ADMIN = 0;
        public const int TYPE_CUSTOM = 1;




        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            TicketManagers = new HashSet<TicketManager>();
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Tên")]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [DisplayName("Email")]
        [StringLength(255)]
        public string email { get; set; }

        [DisplayName("CCCD")]
        [StringLength(255)]
        public string cccd { get; set; }

        [DisplayName("Địa chỉ")]
        [StringLength(255)]
        public string address { get; set; }

        [DisplayName("SĐT")]
        [StringLength(255)]
        public string phone_number { get; set; }

        [Required]
        [DisplayName("Mật khẩu")]
        [StringLength(255)]
        public string password { get; set; }

        [DisplayName("Phân loại")]
        public int user_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketManager> TicketManagers { get; set; }

        public static bool  emailExists(string email)
        {
            User user = db.Users.Where(s => s.email == email).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public string getType()
        {
            string response = "";
            switch (this.user_type)
            {

                case User.TYPE_ADMIN:
                    response = "ADMIN";
                    break;
                case User.TYPE_CUSTOM:
                    response = "CUSTOM";
                    break;
                default:
                    response = "CUSTOM";
                    break;
            }
            return response;
        }
    }
}
