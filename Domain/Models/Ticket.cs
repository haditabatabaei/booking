namespace dotnetcoreapi.Domain.Models
{
    public class Ticket
    {   
        public int id { get; set; }
        
        public int userId { get; set; }
        
        public int showId { get; set; }
        public Show show { get; set; }

        public int seatId { get; set; }

        public Seat seat { get; set; }

        public Ticket(int id, int userId, int ShowId, int seatId) {
            this.id = id;
            this.userId = userId;
            this.showId = ShowId;
        }
    }
}