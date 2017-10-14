using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;

namespace GoogleAuthDemoBarebones.Website.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult SignIn()
        {
            return new GoogleAuthenticationResult();
        }

        public ActionResult Callback()
        {
            var externalLoginInfo = HttpContext.GetOwinContext().Authentication.GetExternalLoginInfo();
            
            return View(externalLoginInfo); // Don't pass the ExternlLoginInfo class to the view, this is just for demo purposes
        }
    }

    public class GoogleAuthenticationResult : HttpUnauthorizedResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            var authenticationProperties = new AuthenticationProperties();

            authenticationProperties.RedirectUri = "/auth/callback";

            context.HttpContext.GetOwinContext().Authentication.Challenge(authenticationProperties, "Google"); // Case sensitive, must be Google
        }
    }
}