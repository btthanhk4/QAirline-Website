namespace AirlinesReservationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketManager")]
    public partial class TicketManager
    {

        public const int STATUS_PAY = 0;
        public const int STATUS_CANCEL = 1;

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("FlightSchedule")]
        public int flight_schedules_id { get; set; }

        [DisplayName("User")]
        public int user_id { get; set; }

        [DisplayName("Trạng thái")]
        public int status { get; set; }

        [DisplayName("Mã")]
        public string code { get; set; }

        public virtual FlightSchedule FlightSchedule { get; set; }

        public virtual User User { get; set; }

        public string getStatus()
        {
            string status = "";
            switch (this.status)
            {
                case TicketManager.STATUS_PAY:
                    status = "PAY";
                    break;
                case TicketManager.STATUS_CANCEL:
                    status = "CANCEL";
                    break;
            }
            return status;
        }

        public bool isCancel()
        {
            if(this.status == TicketManager.STATUS_CANCEL)
            {
                return true;
            }
            return false;
        }

        public string getLabelStatus()
        {
            string label = "";
            switch (this.status)
            {
                case TicketManager.STATUS_CANCEL:
                    label = "danger";
                    break;
                case TicketManager.STATUS_PAY:
                    label = "success";
                    break;
                default:
                    label = "success";
                    break;
            }
            return label;
        }
    }
}
