using SpecFlowProjectBlogAndre.Actions;
using SpecFlowProjectBlogAndre.Context;
using SpecFlowProjectBlogAndre.Models;

namespace SpecFlowProjectBlogAndre.Steps
{
    [Binding]
    public class ConsultantSteps
    {
        private ConsultantContext _consultantContext;
        private FunctionTitleActions _functionTitleActions;

        private List<NewsparkFunctionTitlesModel> _consultantsFunctionTitleOverview;

        public ConsultantSteps(ConsultantContext consultantContext)
        {
            _consultantContext = consultantContext;
            _functionTitleActions = new FunctionTitleActions();
        }

        [Given(@"consultant '([^']*)' is an employee of Newspark")]
        public async Task GivenConsultantIsAnEmployeeOfNewspark(string consultantName)
        {
            _consultantsFunctionTitleOverview = await _functionTitleActions.GetConsultantsFunctionTitle(consultantName);
            _consultantsFunctionTitleOverview.Should().NotBeNull();
            _consultantsFunctionTitleOverview.Count().Should().Be(1, $"expect only and exact 1 employee with the name '{consultantName}'");
            _consultantsFunctionTitleOverview.First().Name.Should().Be(consultantName);
            _consultantContext.Consultant = consultantName;
        }

        [When(@"his role is '([^']*)'")]
        public Task WhenHisRoleIs(string roleName)
        {
            _consultantsFunctionTitleOverview.First().Name.Should().Be(_consultantContext.Consultant);
            _consultantsFunctionTitleOverview.First().Title.Should().Contain(roleName);
            return Task.CompletedTask;
        }
    }
}