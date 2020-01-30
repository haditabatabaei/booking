using System;

namespace dotnetcoreapi.Domain.Models
{
    public class Show
    {
        public int Id{get;set;}

        public string title {get;set;}

        public double price {get;set;}

        public int salon_id {get;set;}

        public DateTime start_time  {get;set;}

        public DateTime end_time {get;set;}

        public Salon salon {get;set;}

        public Show(int Id,string title,double price, int salon_id,DateTime start_time, DateTime end_time) {
            this.Id = Id;
            this.title = title;
            this.price = price;
            this.salon_id = salon_id;
            this.start_time = start_time;
            this.end_time = end_time;
        }
    }
}