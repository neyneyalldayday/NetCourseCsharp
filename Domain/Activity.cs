namespace Domain
{
    public class Activity
    {
        public Activity(
            Guid id,
         string title, 
         string Description, 
         string Category, 
         string City, 
         string Venue
         )
        {
            this.Id = id;
            this.Title = title;
            this.Description = Description;
            this.Category = Category;
            this.City = City;
            this.Venue = Venue;

        }
        public Guid Id { get; set; }

        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }




    }
}