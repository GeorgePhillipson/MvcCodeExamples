using System.Collections.Generic;
using Web.Helper.ListHelper;

namespace Web.Model.ListViewModel
{
    public class ExampleOfListViewModel
    {
        public List<PetList> ListOfPets                 { get; set; }
        public List<string> ListOfPetsDuplicates       { get; set; }
        public List<int> ListOfInts                     { get; set; }
        public List<string> ListOfStrings               { get; set; }
        public List<int> ListOfIntsJoined               { get; set; }
        public List<int> ListOfIntsSorted               { get; set; }
    }
}
