﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BeerUAPI.Controllers
{
    public class BaseController : ApiController
    {
        protected string BaseUrl
        {
            get { return "https://api.brewerydb.com/v2/"; }
        }

        protected string Key
        {
            get { return "&key=8e74edb7320a50dc432315543c2de1f8"; }
        }

        protected string UserName
        {
            get { return "jake_nyenhuis@live.com"; }
        }

        protected string Password
        {
            get { return "BeerU10"; }
        }

        protected string Get
        {
            get { return "Get"; }
        }

        protected string ContentType
        {
            get { return "application/json"; }
        }
    }
}