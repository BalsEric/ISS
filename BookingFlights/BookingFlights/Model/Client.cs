namespace BookingFlights.Model
{
    public class Client : Entity<int>
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }

        public Client(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
        }

        public Client(int id, string username, string password, string name)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.name = name;
        }
    }
}