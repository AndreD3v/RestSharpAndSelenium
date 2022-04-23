namespace SpecFlowProjectBlogAndre.Models
{
    public class ConsultantExperienceModel
    {
        public int Id { get; set; }
        public List<string> Clients { get; set; } = new();
        public string Consultant { get; set; }
    }
}
