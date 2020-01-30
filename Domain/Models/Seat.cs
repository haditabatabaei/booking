namespace dotnetcoreapi.Domain.Models
{
    public class Seat
    {
        public int id { get; set; }
        public float posX { get; set; }

        public float posY { get; set; }
        
        public int salonId { get; set; }

        public Salon salon { get; set; }

        public Seat(int id, float posX, float posY, int salonId) {
            this.id = id;
            this.posX = posX;
            this.posY = posY;
            this.salonId = salonId;
        }
    }
}