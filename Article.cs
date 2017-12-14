namespace SampleMvc.Models
{
    /// <summary>
    /// 記事
    /// </summary>
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }
    }
}
