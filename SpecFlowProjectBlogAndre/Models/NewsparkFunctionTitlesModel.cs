namespace SpecFlowProjectBlogAndre.Models
{
    public class NewsparkFunctionTitlesModel
    {
        public int Id { get; set; }
        public List<string> Title { get; set; } = new();
        public string Name { get; set; }
    }
}