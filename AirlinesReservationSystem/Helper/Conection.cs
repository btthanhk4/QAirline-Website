using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirlinesReservationSystem.Models;

namespace AirlinesReservationSystem.Helper
{
    public class Conection
    {
        public static Model1 getDb()
        {
            return new Model1();
            
        }
    }
}