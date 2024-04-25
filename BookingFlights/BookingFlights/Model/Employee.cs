namespace BookingFlights.Model
{
    public class Employee : Entity<int>
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }

        public Employee(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
        }

        public Employee(int id, string username, string password, string name)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.name = name;
        }
    }
}