namespace BookingFlights.Model
{
    public class Request : Entity<int>
    {
        public int id { get; set; }
        public RequestType type { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string cnp { get; set; }
        public string birthday { get; set; }
        public int ticketid { get; set; }

        public Request(int id, RequestType type, string lastname, string firstname, string cnp, string birthday, int ticketid)
        {
            this.id = id;
            this.type = type;
            this.lastname = lastname;
            this.firstname = firstname;
            this.cnp = cnp;
            this.birthday = birthday;
            this.ticketid = ticketid;
        }

        public Request(RequestType type, string lastname, string firstname, string cnp, string birthday, int ticketid)
        {
            this.type = type;
            this.lastname = lastname;
            this.firstname = firstname;
            this.cnp = cnp;
            this.birthday = birthday;
            this.ticketid = ticketid;
        }
    }
}