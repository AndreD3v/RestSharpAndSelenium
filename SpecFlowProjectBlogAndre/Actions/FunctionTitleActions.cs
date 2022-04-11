using RestSharp;
using SpecFlowProjectBlogAndre.Models;

namespace SpecFlowProjectBlogAndre.Actions
{
    public class FunctionTitleActions
    {
        private RestClient _client = new RestClient("http://localhost:3000/");
        public async Task<List<NewsparkFunctionTitlesModel>> GetConsultantsFunctionTitle(string consultantName)
        {
            var request = new RestRequest("functiontitles")
                .AddQueryParameter("name", consultantName);
            var response = await _client.GetAsync<List<NewsparkFunctionTitlesModel>>(request);

            return response;
        }
    }
}