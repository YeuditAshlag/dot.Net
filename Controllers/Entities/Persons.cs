namespace Appfor_thehotel.Controllers.Entities
{
    public class Persons
    {

        public int idPerson { get; set; }
        public string name { get; set; }
        public int fName { get; set; }
        public int numPhone { get; set; }
        public Rooms idroom { get; set; }
        List<Persons> allPersons = new List<Persons>();
        public Dates time   { get; set; }
        


        public Persons(int id, string name, int fName, int numPhone, List<Persons> allPerson, Rooms idroom)
        {
            this.idPerson = id;
            this.name = name;
            this.fName = fName;
            this.numPhone = numPhone;
            this.allPersons = allPerson;
            this.idroom = idroom;
        }
    }
}
