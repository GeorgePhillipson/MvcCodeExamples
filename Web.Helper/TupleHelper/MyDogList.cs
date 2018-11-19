using System.Collections.Generic;

namespace Web.Helper.TupleHelper
{
    public class MyDogList
    {
        public IEnumerable<string> DogList()
        {
            List<string> dogs = new List<string> { "German Shepherd", "Siberian Husky", "Bernese Mountain Dog" };

            return dogs;
        }

        public string TestString    = "My favourite dogs is a : ";
        public bool ItsTrue         = true;
    }
}
