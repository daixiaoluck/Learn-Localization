using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearnGlobalization.Controllers
{
    public class BaseController:Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            RouteValueDictionary rvd = requestContext.RouteData.Values;
            if(rvd.ContainsKey("lang"))
            {
                CultureInfo ci = new CultureInfo(rvd["lang"].ToString());
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = ci;
            }
            base.Initialize(requestContext);
        }
    }
}