using System;
namespace dotnetcoreapi.Domain.Models
{
    public class Show
    {
        public int id{ get; set; }

        public string title { get; set; }

        public double price { get; set; }

        public int salonId { get; set; }

        public DateTime startTime  { get; set; }

        public DateTime endTime { get; set; }

        public Salon salon { get; set; }

        public Show(int id, string title, double price, int salonId, DateTime startTime, DateTime endTime) {
            this.id = id;
            this.title = title;
            this.price = price;
            this.salonId = salonId;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}