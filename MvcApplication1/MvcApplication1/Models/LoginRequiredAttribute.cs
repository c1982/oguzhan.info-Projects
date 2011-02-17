using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class LoginRequiredAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["isLogIn"] == null)
                filterContext.Result = new RedirectResult("~/Home/Login");

            base.OnActionExecuting(filterContext);
        }
    }
}