namespace dotnetcoreapi.Domain.Models
{
    public class Salon
    {
        public int id  { get; set; }
        public string name { get; set; }
        public float seatWidth { get; set; }
        public float seatHeight { get; set; }

        public Salon(int id, string name, float seatWidth, float seatHeight) {
            this.id = id;
            this.name = name;
            this.seatHeight = seatHeight;
            this.seatWidth = seatWidth;
        }

    }

}