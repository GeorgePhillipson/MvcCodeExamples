using System.Collections.Generic;
using Web.Model.TypesOfPets;

namespace Web.Model.TestSearchData
{
    public static class TestSearchData
    {
        public static IEnumerable<TypeOfPetsViewModel> DogList()
        {
            List<TypeOfPetsViewModel> typesOfPet = new List<TypeOfPetsViewModel>
            {
                new TypeOfPetsViewModel("dog", "German Shepherd"),
                new TypeOfPetsViewModel("dog", "Husky"),
                new TypeOfPetsViewModel("cat", "Russian Blue"),
                new TypeOfPetsViewModel("fish", "Goldfish")
            };
            return typesOfPet;
        }
    }
}
