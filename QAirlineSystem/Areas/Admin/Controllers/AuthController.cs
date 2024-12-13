using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AirlinesReservationSystem.Helper;

namespace AirlinesReservationSystem.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        // GET: Admin/Auth
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (AuthHelper.getIdentity() == null)
            {
                //filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.Forbidden, "Forbidden");
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary(new { Controller = "Security", Action = "Login" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}