using System.Linq;
using System.Web.Mvc;
using Web.Helper.TupleHelper;
using Web.Model.TupleViewModel;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var tupleValue = new MyDogList();

            var model = new TuplesViewModel
            {
                TestString = tupleValue.TestString,
                ListOfDogs = tupleValue.DogList().Where(x => x.Contains("German Shepherd")),
                IsItTrue = tupleValue.ItsTrue
            };
            return View(model);
        }
    }
}