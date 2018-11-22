using System;
using System.Web;

namespace Web.RequiresHttps
{
    public class RequiresHttps : IHttpModule
    {

        public void Init(HttpApplication app)
        {
            app.BeginRequest += (App_BeginRequest);

        }

        private void App_BeginRequest(object sender, EventArgs e)
        {
            if (!HttpContext.Current.Request.IsSecureConnection)
            {
                string redirectUrl = HttpContext.Current.Request.Url.ToString().Replace("http:", "https:");
                HttpContext.Current.Response.Redirect(redirectUrl);
            }
        }

        public void Dispose()
        {
            // Needed for IHttpModule
        }
    }

    public class ExpectCtHeader : IHttpModule
    {

        public void Init(HttpApplication app)
        {
            app.BeginRequest += (App_BeginRequest);

        }

        private void App_BeginRequest(object sender, EventArgs e)
        {
            //In production check that connection is secure
           // if (HttpContext.Current.Request.IsSecureConnection)
           // {
                string baseUrl = "https://xxxxx.report-uri.com/r/d/ct/enforce";
                string headerValue = $"max-age=15, report-uri=\"{baseUrl}";
                HttpContext.Current.Response.AddHeader("Expect-CT", headerValue);
           // }
        }

        public void Dispose()
        {
            // Needed for IHttpModule
        }
    }
}
