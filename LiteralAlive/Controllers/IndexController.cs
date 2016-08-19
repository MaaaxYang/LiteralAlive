using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LiteralAlive.Controllers
{
    public class IndexController : ApiController
    {
        public object Get()
        {
            return "1";
        }
    }
}
