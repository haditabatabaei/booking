namespace dotnetcoreapi.Domain.Models
{
    public class Ticket
    {   
        public int Id{get;set;}
        
        public int UserId {get;set;}
        
        public int ShowId {get;set;}
        public Show Show{get;set;}

        public int SeatId {get;set;}

        public Seat Seat{get;set;}

        public Ticket(int Id, int UserId, int ShowId, int SeatId) {
            this.Id = Id;
            this.UserId = UserId;
            this.ShowId = ShowId;
        }
    }
}