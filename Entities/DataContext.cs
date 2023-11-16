namespace Appfor_thehotel.Entities
{
    public class DataContext
    {
        public static List<Persons> allPersons = new List<Persons>
        {
            new Persons{ idPerson=332225678, name="yudit", fName="ashlag",numPhone= 0583261142,idroom= new Rooms(1, 6, false) ,time=new Dates(true,new DateTime(01,08,2022),new DateTime(02,08,2022),1)},
            new Persons{ idPerson=332225678, name="yudit", fName="ashlag",numPhone= 0583261142,idroom= new Rooms(1, 6, false) ,time=new Dates(true,new DateTime(01,08,2022),new DateTime(02,08,2022),1)},
            new Persons{ idPerson=332225678, name="yudit", fName="ashlag",numPhone= 0583261142,idroom= new Rooms(1, 6, false) ,time=new Dates(true,new DateTime(01,08,2022),new DateTime(02,08,2022),1)}
        };

        public static List<Rooms> roomList = new List<Rooms>
        {
            new Rooms{idRoom=1234,numOfBeds=6,IsFilled=false},
            new Rooms{idRoom=1456,numOfBeds=6,IsFilled=false},
            new Rooms{idRoom=1456,numOfBeds=6,IsFilled=true},
        };
         
        public static List<Dates> dateList = new List<Dates>
        {
            new Dates{IsCatch=true,start=new DateTime(01,08,2022),end=new DateTime(02,08,2022),count=2},
            new Dates{IsCatch=true,start=new DateTime(01,08,2022),end=new DateTime(02,08,2022),count=3},
            new Dates{IsCatch=true,start=new DateTime(01,08,2022),end=new DateTime(02,08,2022),count=2},
            new Dates{IsCatch=false,start=new DateTime(01,08,2022),end=new DateTime(02,08,2022),count=5},
        };


    }
}
