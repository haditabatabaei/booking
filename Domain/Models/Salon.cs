namespace dotnetcoreapi.Domain.Models
{
    public class Salon
    {
        public int Id{get; set;}
        public string Name {get; set;}
        public float SeatWidth{get;set;}
        public float SeatHeight{get;set;}

        public Salon(int Id,string Name, float SeatWidth,float SeatHeight) {
            this.Id = Id;
            this.Name = Name;
            this.SeatHeight = SeatHeight;
            this.SeatWidth = SeatWidth;
        }

    }

}