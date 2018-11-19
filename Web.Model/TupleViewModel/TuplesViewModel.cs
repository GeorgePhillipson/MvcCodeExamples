using System.Collections.Generic;

namespace Web.Model.TupleViewModel
{
    public class TuplesViewModel
    {
        public string TestString                    { get; set; }
        public IEnumerable<string> ListOfDogs       { get; set; }
        public bool IsItTrue                        { get; set; }
    }
}
