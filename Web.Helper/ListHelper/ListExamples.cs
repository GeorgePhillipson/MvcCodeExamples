using System.Collections.Generic;

namespace Web.Helper.ListHelper
{
    public class PetList
    {
        public PetList(string stringId, string stringValue)
        {
            StringId        = stringId;
            StringValue     = stringValue;
        }
        public string StringId      { get;}
        public string StringValue   { get;}
    }


    public class ListOfIntsSixToTen
    {
        public List<int> ReturnListOfInts()
        {
            List<int> listOfInts = new List<int>
            {
                10,
                6,
                8,
                7,
                9
            };

            return listOfInts;
        }
    }

    public class ListExamples
    {

        public List<int> ReturnListOfInts()
        {
            List<int> listOfInts = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            return listOfInts;
        }

        public List<int> ReturnListOfIntsJoin()
        {
            ListOfIntsSixToTen newList      = new ListOfIntsSixToTen();
            List<int> intsInAnotherClass    = newList.ReturnListOfInts();

            List<int> intsInThisClass = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            intsInThisClass.AddRange(intsInAnotherClass);

            return intsInThisClass;
        }

        public List<int> SortReturnListOfInts()
        {
            ListOfIntsSixToTen newList = new ListOfIntsSixToTen();

            var sortList = newList.ReturnListOfInts();
            sortList.Sort();
 
            return sortList;
        }



        public List<string> ReturnListOfStrings()
        {
            List<string> listOfStrings = new List<string>
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five"
            };

            return listOfStrings;
        }

        public List<PetList> ReturnListOfPets()
        {
            List<PetList> listOfPets = new List<PetList>
            {
                new PetList("Dog", "German Shepherd"),
                new PetList("Dog", "German Shepherd"),
                new PetList("Cat", "Russian Blue"),
                new PetList("Cat", "Persian Cat"),
                new PetList("Cat", "Persian Cat")
            };

            return listOfPets;

        }
    }
}
