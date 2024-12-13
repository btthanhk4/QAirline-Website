using System.Collections.Generic;
using System.Web.Mvc;
using AirlinesReservationSystem.Helper;
using Newtonsoft.Json;
using AirlinesReservationSystem.Models;
using System.Linq;
using System;

namespace AirlinesReservationSystem.Controllers
{
    public class SecurityController : Controller
    {
		Model1 db = new Model1();

        public object EntityValidationErrors { get; private set; }

        public ActionResult Login(string email = "", string password = "")
		{
			Dictionary<string, string> response = new Dictionary<string, string>();
			response["status"] = "200";
			response["message"] = "";
			User user = Conection.getDb().Users.Where(s => s.email == email).FirstOrDefault();
			if(user == null || user.password != password)
            {
				response["status"] = "400";
				response["message"] = "Thông tin tài khoản không hợp lệ.";
            }
            else
            {

				AuthHelper.setIdentity(user);
				AlertHelper.setToast("success", "Đăng nhập thành công.");
			}
			return Content(JsonConvert.SerializeObject(response));
		}

		public ActionResult Logout()
        {
			if(AuthHelper.isLogin() == true)
            {
				AuthHelper.removeIdentity();
				AlertHelper.setToast("warning", "Đăng xuất thành công.");
			}
			return RedirectToAction("Index", "Home");
        }

		public ActionResult Register(string email,string password,string rePassword)
        {
			Dictionary<string, string> response = new Dictionary<string, string>();
			response["status"] = "200";
			response["message"] = "";
			if(rePassword != password)
            {
				response["status"] = "400";
				response["message"] = "Mật khẩu không khớp nhau.";
				return Content(JsonConvert.SerializeObject(response));
			}
			if(Models.User.emailExists(email) == true)
            {
				response["status"] = "400";
				response["message"] = "Email này đã tồn tại.";
				return Content(JsonConvert.SerializeObject(response));
			}
			User model = new User();
			model.email = email;
			model.password = password;
			model.user_type = Models.User.TYPE_CUSTOM;
            if (ModelState.IsValid)
            {
				db.Users.Add(model);
				db.SaveChanges();
				AlertHelper.setToast("success", "Tạo tài khoản mới thành công.");
				response["message"] = "Tạo tài khoản mới thành công.";
            }
            else
            {
				response["status"] = "400";
				response["message"] = JsonConvert.SerializeObject(ModelState.Values.Select(e => e.Errors).ToList());
			}
			return Content(JsonConvert.SerializeObject(response));
		}
	}
}