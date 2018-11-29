namespace Web.Model.TypesOfPets
{
    public class TypeOfPetsViewModel
    {
        public TypeOfPetsViewModel(string petTypeId, string petType)
        {
            PetTypeId   = petTypeId;
            PetType     = petType;
        }

        public string PetTypeId     { get; }
        public string PetType       { get; }
    }
}
