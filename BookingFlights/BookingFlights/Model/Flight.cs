namespace BookingFlights.Model
{
    public class Flight : Entity<int>
    {
        public int id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string date { get; set; }
        public int total_seats { get; set; }
        public int available_seats { get; set; }
        public float price { get; set; }

        public Flight(int id, string from, string to, string date, int total_seats, int available_seats, float price)
        {
            this.id = id;
            this.from = from;
            this.to = to;
            this.date = date;
            this.total_seats = total_seats;
            this.available_seats = available_seats;
            this.price = price;
        }

        public Flight(string from, string to, string date, int total_seats, int available_seats, float price)
        {
            this.from = from;
            this.to = to;
            this.date = date;
            this.total_seats = total_seats;
            this.available_seats = available_seats;
            this.price = price;
        }
    }
}