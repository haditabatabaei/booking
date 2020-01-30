namespace dotnetcoreapi.Domain.Models
{
    public class Ticket
    {   
        public int Id{get;set;}
        
        public int user_id {get;set;}
        
        public int show_id {get;set;}
        public Show show{get;set;}

        public int seat_id {get;set;}

        public Seat seat{get;set;}

        public Ticket(int Id, int user_id, int show_id, int seat_id) {
            this.Id = Id;
            this.user_id = user_id;
            this.show_id = show_id;
        }
    }
}