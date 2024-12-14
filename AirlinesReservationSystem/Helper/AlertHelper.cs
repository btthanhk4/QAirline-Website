using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Helper
{
    public class AlertHelper
    {
        public static string showAlert()
        {
            string html = "";
            html = "<div class=\"alert alert-{{type}} alert - dismissible fade show mt-2\" role=\"alert\">";
            html += "{{message}}";
            html += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">";
            html += "<span aria-hidden=\"true\">&times;</span>";
            html += "</button>";
            html += "</div>";
            string type = (string)HttpContext.Current.Session["typeAlert"];
            string message = (string)HttpContext.Current.Session["messageAlert"];
            HttpContext.Current.Session.Remove("typeAlert");
            HttpContext.Current.Session.Remove("messageAlert");
            if (type != null && message != null)
            {
                html = html.Replace("{{type}}", type);
                html = html.Replace("{{message}}", message);
                return html;
            }
            return null;
        }

        public static void setAlert(string type,string message)
        {
            HttpContext.Current.Session["typeAlert"] = type;
            HttpContext.Current.Session["messageAlert"] = message;
        }

        public static string showToast()
        {
            string type = (string)HttpContext.Current.Session["typeToast"];
            string message = (string)HttpContext.Current.Session["messageToast"];
            HttpContext.Current.Session.Remove("typeToast");
            HttpContext.Current.Session.Remove("messageToast");
            string html = "";
            html = "<div id=\"snackbar\">";
            html += "<div class=\"alert alert-{{type}} alert-dismissible\">";
            html+= "<a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>";
            html += "<b>{{message}}</b>";
            html += "</div>";
            html += "</div>";
            html += "<script>";
            html+= "var x = document.getElementById(\"snackbar\");"; 
            html += " x.className = \"show\";";
            html += "setTimeout(function () { x.className = x.className.replace(\"show\", \"\"); }, 8000);";
            html += "</script>";
            if (type != null && message != null)
            {
                html = html.Replace("{{type}}", type);
                html = html.Replace("{{message}}", message);
                return html;
            }
            return null;
        }
        public static void setToast(string type, string message)
        {
            HttpContext.Current.Session["typeToast"] = type;
            HttpContext.Current.Session["messageToast"] = message;
        }
    }
}