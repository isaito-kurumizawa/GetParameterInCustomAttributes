using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetParameterInCustomAttributes.Filter
{
    public class GetParameterAttributes : ActionFilterAttribute
    {
        public GetParameterAttributes()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Parameters can be acquired with custom attributes.
            var param = filterContext.ActionParameters["param"];
            base.OnActionExecuting(filterContext);
        }

    }
}