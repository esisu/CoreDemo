namespace CoreDemo.Project.Entities.Concrete
{
    public class BlogRating
    {
        public int BlogRatingId { get; set; }

        public int BlogId { get; set; }

        public int TotalScore { get; set; }

        public int BlogRatingCount { get; set; }
    }
}
