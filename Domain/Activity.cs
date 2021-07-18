using System;

namespace Domain
{
    public class Activity
    {
        public Activity() { }
        public Activity(Guid id, string description, DateTime date, string venue)
        {
            this.Id = id;
            this.Description = description;
            this.Date = date;
            this.Venue = venue;

        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
        

    }
}