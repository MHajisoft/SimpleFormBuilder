using System.Web.Mvc;

namespace SimpleFormBuilder.Util
{
    public static class MvcUtil
    {
        public static string IsActive(this HtmlHelper html, string control)
        {
            var routeData = html.ViewContext.RouteData;

            var routeControl = (string)routeData.Values["controller"];

            var returnActive = control == routeControl;

            return returnActive ? "active" : "";
        }
    }
}