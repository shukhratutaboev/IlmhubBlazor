namespace blazor2.Models
{
    public class Problem
    {
        public int DisplayId { get; set; }

        public string Title { get; set; }
        public int Chapter { get; set; }

        public string Url
        { 
            get => $"http://oj.ilmhub.uz/problems/{DisplayId}";
        } 
    }
}