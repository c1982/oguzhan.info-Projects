using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class CheckBrowserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
                base.OnActionExecuted(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
                var userAgent = filterContext.HttpContext.Request.ServerVariables["HTTP_USER_AGENT"];
                if (userAgent.IndexOf("MSIE") != -1)                
                    filterContext.Result = new ContentResult() 
                                            { Content = "<script>alert('YASAK! FireFox veya Chrome kullanın.');</script>" };
                                
                base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}