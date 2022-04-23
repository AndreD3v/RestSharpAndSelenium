namespace SpecFlowProjectBlogAndre.Models
{
    public class ConsultantKnowledgeModel
    {
        public int Id { get; set; }
        public List<string> Skill { get; set; } = new();
        public string Consultant { get; set; }
    }
}
