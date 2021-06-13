namespace backend.Models
{
    public class Block
    {
        public int Id { get; set; }
        public string Tag { get; set; } // img, h1, h2, h3, p
        public string Content { get; set; }
        public int PageId { get; set; }
        public Page Page { get; set; }
    }
}