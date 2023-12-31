﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace GetEmpStatMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string apiUrl = "http://localhost/WebAPI/Api/users/";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string responseData = reader.ReadToEnd();

                List<User> users = JsonConvert.DeserializeObject<List<User>>(responseData);

                return View(users);
            }
        }
    }
}
