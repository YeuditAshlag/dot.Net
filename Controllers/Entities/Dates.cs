namespace Appfor_thehotel.Controllers.Entities
{
    public class Dates
    {
      
        public bool IsCatch { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public int count { get; set; }

        public Dates(bool isCatch, DateTime start, DateTime end, int count)
        {
            this.IsCatch = isCatch;
            this.start = start;
            this.end = end;
            this.count = count;
           
        }

        public Dates(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
