namespace BookingFlights.Model
{
    public class Ticket : Entity<int>
    {
        public int id { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string cnp { get; set; }
        public string birthday { get; set; }
        public int flightid { get; set; }
        public int clientid { get; set; }

        public Ticket(int id, string lastname, string firstname, string cnp, string birthday, int flightid, int clientid)
        {
            this.id = id;
            this.lastname = lastname;
            this.firstname = firstname;
            this.cnp = cnp;
            this.birthday = birthday;
            this.flightid = flightid;
            this.clientid = clientid;
        }

        public Ticket(string lastname, string firstname, string cnp, string birthday, int flightid, int clientid)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.cnp = cnp;
            this.birthday = birthday;
            this.flightid = flightid;
            this.clientid = clientid;
        }
    }
}