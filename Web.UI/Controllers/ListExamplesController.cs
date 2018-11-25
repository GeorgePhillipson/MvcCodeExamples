using System.Linq;
using System.Web.Mvc;
using Web.Helper.ListHelper;
using Web.Model.ListViewModel;

namespace Web.UI.Controllers
{
    public class ListExamplesController : Controller
    {
        public ActionResult Index()
        {
            ListExamples listExamples = new ListExamples();

            var duplicatePets = listExamples.ReturnListOfPets()
                                            .GroupBy(x => x.StringValue)
                                            .Where(y => y.Count() > 1)
                                            .Select(z => z.Key).ToList();

            var model = new ExampleOfListViewModel
            {
                ListOfPets              = listExamples.ReturnListOfPets(),
                ListOfInts              = listExamples.ReturnListOfInts(),
                ListOfStrings           = listExamples.ReturnListOfStrings(),
                ListOfIntsJoined        = listExamples.ReturnListOfIntsJoin(),
                ListOfPetsDuplicates    = duplicatePets,
                ListOfIntsSorted        = listExamples.SortReturnListOfInts()
            };
            return View("~/Views/Home/ListExamples.cshtml",model);
        }
    }
}