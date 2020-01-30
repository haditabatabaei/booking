namespace dotnetcoreapi.Domain.Models
{
    public class Seat
    {
        public int Id{get;set;}
        public float PosX {get;set;}

        public float PosY {get;set;}
        
        public int SalonId {get;set;}

        public Salon Salon {get;set;}

        public Seat(int Id,float PosX, float PosY, int SalonId) {
            this.Id = Id;
            this.PosX = PosX;
            this.PosY = PosY;
            this.SalonId = SalonId;
        }
    }
}