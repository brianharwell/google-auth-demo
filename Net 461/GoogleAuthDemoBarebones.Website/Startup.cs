using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Google;
using Owin;

[assembly: OwinStartup(typeof(GoogleAuthDemoBarebones.Website.Startup))]
namespace GoogleAuthDemoBarebones.Website
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            var googleOAuth2AuthenticationOptions = new GoogleOAuth2AuthenticationOptions();

            googleOAuth2AuthenticationOptions.ClientId = "<ENTER YOUR CLIENT ID>";
            googleOAuth2AuthenticationOptions.ClientSecret = "<ENTER YOUR CLIENT SECRET>";

            app.UseGoogleAuthentication(googleOAuth2AuthenticationOptions);
        }
    }
}
