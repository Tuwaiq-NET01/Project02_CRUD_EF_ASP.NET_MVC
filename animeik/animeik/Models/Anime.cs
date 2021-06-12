namespace animeik.Models
{
    public class Anime
    {
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string type { get; set; }
        public int episodes { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public double score { get; set; }
        public int Categoryid { get; set; }

        // public Anime(int id,string title, string url, string imageUrl, string type,string startDate, string endDate, double score)
        // {
        //     this.id = id;
        //     this.title = title;
        //     this.url = url;
        //     image_url = imageUrl;
        //     this.type = type;
        //     start_date = startDate;
        //     this.score = score;
        //     this.end_date = endDate;
        // }
    }
}