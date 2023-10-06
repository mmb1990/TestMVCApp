using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestMVCApp.WebApp.Models;

namespace TestMVCApp.WebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            UserMST user = new UserMST();
           // user.startDate = DateTime.Now;
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserMST user) 
        {
            string connectionstr = ConfigurationManager.ConnectionStrings["myconnect"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("Select * FROM UserMST WHERE userpassword = '{0}' and Email='{1}'", user.userpassword, user.email);
                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return View("Success");
                }
            }
            return View("ErrorPage");
        }
    }
}