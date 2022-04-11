using SpecFlowProjectBlogAndre.Actions;
using SpecFlowProjectBlogAndre.Context;

namespace SpecFlowProjectBlogAndre.Steps
{
    [Binding]
    public class ConsultantKnowledgeSteps
    {
        private ConsultantContext _consultantContext;
        private KnowledgeAndExperienceActions _knowledgeAndExperienceActions;

        public ConsultantKnowledgeSteps(ConsultantContext consultantContext)
        {
            _consultantContext = consultantContext;
            _knowledgeAndExperienceActions = new KnowledgeAndExperienceActions();
        }

        [Then(@"he should have knowledge of '([^']*)'")]
        public async Task ThenHeShouldHaveKnowledgeOf(string toolName)
        {
            var consultantToCheck = _consultantContext.Consultant;

            var response = await _knowledgeAndExperienceActions.GetConsultantsKnowledge(consultantToCheck);
            
            response.Should().NotBeNull($"expect knowledge data of consultant " +
                $"'{consultantToCheck}' to be available, but received {response}");

            response.Count.Should().Be(1, $"expect to have 1 consultant '{consultantToCheck}' to have experience with {toolName}");
            response.First().Consultant.Should().Be(consultantToCheck);
            response.First().Skill.Should().Contain(toolName);
        }

        [Then(@"he gained test experience at '([^']*)'")]
        public async Task ThenHeGainedTestExperienceAt(string clientName)
        {
            var consultantToCheck = _consultantContext.Consultant;

            var response = await _knowledgeAndExperienceActions.GetConsultantsExperience(consultantToCheck);

            response.Should().NotBeNull($"expect experience data of consultant " +
                $"'{consultantToCheck}' to be available, but received {response}");

            var consultantExperience = response.SingleOrDefault(x => x.Consultant == consultantToCheck);
            consultantExperience.Should().NotBeNull($"expect {consultantToCheck} to have experience at client '{clientName}'");
            consultantExperience.Clients.Should().Contain(clientName);
        }
    }
}