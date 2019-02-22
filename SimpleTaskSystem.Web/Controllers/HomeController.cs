﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SimpleTaskSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SimpleTaskSystemControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}