using RestSharp;
using SpecFlowProjectBlogAndre.Models;

namespace SpecFlowProjectBlogAndre.Actions
{
    public class KnowledgeAndExperienceActions
    {
        private RestClient _client = new RestClient("http://localhost:3000/");
                     
        public async Task<List<ConsultantKnowledgeModel>> GetConsultantsKnowledge(string consultantName)
        {
            var request = new RestRequest("knowledge")
                .AddQueryParameter("consultant", consultantName);
            var response = await _client.GetAsync<List<ConsultantKnowledgeModel>>(request);

            return response;
        }

        public async Task<List<ConsultantExperienceModel>> GetConsultantsExperience(string consultantName)
        {
            var request = new RestRequest("experience")
                .AddQueryParameter("consultant", consultantName);
            var response = await _client.GetAsync<List<ConsultantExperienceModel>>(request);

            return response;
        }
    }
}