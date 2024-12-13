using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Helper
{
    public class MoneyHelper
    {
        public static string showVND(int money)
        {
            var currency = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            return String.Format(currency, "{0:c0}", money);
        }
    }
}