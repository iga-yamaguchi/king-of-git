namespace SampleMvc.Models
{
    /// <summary>
    /// 記事
    /// </summary>
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
