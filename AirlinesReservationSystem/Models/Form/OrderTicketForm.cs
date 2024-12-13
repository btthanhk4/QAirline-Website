using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models.Form
{
    public class OrderTicketForm
    {
        [Required]
        public int from { get; set; }
        [Required]
        public int to { get; set; }
        [Required]
        public string repartureDate { get; set; }
        public string returnDate { get; set; }

        //public bool roundTrip { get; set; }


        public bool checkDestination()
        {
            if(this.to != this.from)
            {
                return true;
            }
            return false;
        }

        public bool isRoundTrip()
        {
            if(this.repartureDate != null && this.returnDate != null)
            {
                return true;
            }
            return false;
        }

    }
}