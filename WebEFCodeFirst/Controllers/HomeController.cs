using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebEFCodeFirst.Controllers
{
    public class HomeController : Controller
    {

        public void Agente()
        {
            Response.Write("<h3>Hello MVC!</h3>");
            Response.Write("<ul> <li>Welcome, you are using " + Request.Browser.Browser);
            Response.Write(" and your address is " + Request.UserHostAddress + "! </li>");
            Response.Write("<li>User agent: " + Request.UserAgent + "</li>");
            Response.Write("<li>httpMethod: " + Request.HttpMethod + "</li>");
            foreach (String s in Request.AcceptTypes)
            {
                Response.Write("<li>AcceptTypes: " + s + "</li>");
            }
            foreach (String s in Request.UserLanguages)
            {
                Response.Write("<li>User languages: " + s + "</li>");
            }
            Response.Write("</ul>");
        }


        public void HelloName(string name)
        {
            string value = HttpUtility.HtmlEncode(name);
            Response.Write("<H1>Hello ");
            Response.Write(value);
            Response.Write("!</H1>");
        }
        public void HelloId(string id)
        {
            string value = HttpUtility.HtmlEncode(id);
            Response.Write("<H1>Hello ");
            Response.Write(value);
            Response.Write("!</H1>");
        }



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}