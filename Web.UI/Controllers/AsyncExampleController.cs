using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Web.Model.TestSearchData;

namespace Web.UI.Controllers
{
    public class AsyncExampleController : Controller
    {
        // GET: AsyncExample
        public ActionResult Index()
        {
            return View("~/Views/AsyncExample/AsyncExample.cshtml");
        }

        [HttpPost]
        public ActionResult Result(string param)
        {
            //Before starting, we would check that param is not null!!
            var result = TestSearchData.DogList().Where(x=> string.Equals(x.PetTypeId, param, StringComparison.CurrentCultureIgnoreCase)).ToList();

            StringBuilder sb = new StringBuilder();
            
            if (result.Any())
            {
                sb.Append($"<h2 class=\"text-success\">Found {result.Count} results for {param}</h2>");
                sb.Append("<ol>");
                foreach (var pet in result)
                {
                    sb.Append($"<li>{pet.PetType}</li>");
                }

                sb.Append("</ol>");
            }
            else
            {
                sb.Append($"<h2 class=\"text-danger\">Found {result.Count} results for {param}</h2>");
            }

            string returnValue = sb.ToString();

            if (Request.IsAjaxRequest())
            {
                return Json(new { Confirm = true, message = $"{returnValue}" }, JsonRequestBehavior.AllowGet);
            }

            //Ignore this part as only doing async example
            return View("~/Views/AsyncExample/AsyncExample.cshtml");
        }
    }
}