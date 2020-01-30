namespace dotnetcoreapi.Domain.Models
{
    public class Salon
    {
        public int Id{get; set;}
        public string name {get; set;}
        public float seat_width{get;set;}
        public float seat_height{get;set;}

        public Salon(int Id,string name, float seat_width,float seat_height) {
            this.Id = Id;
            this.name = name;
            this.seat_height = seat_height;
            this.seat_width = seat_width;
        }

    }

}