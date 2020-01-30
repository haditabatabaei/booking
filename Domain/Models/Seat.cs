namespace dotnetcoreapi.Domain.Models
{
    public class Seat
    {
        public int Id{get;set;}
        public float x {get;set;}

        public float y {get;set;}
        
        public int salon_id {get;set;}

        public Salon salon {get;set;}


        public Seat(int Id,float x, float y, int salon_id) {
            this.Id = Id;
            this.x = x;
            this.y = y;
            this.salon_id = salon_id;
        }
    }
}