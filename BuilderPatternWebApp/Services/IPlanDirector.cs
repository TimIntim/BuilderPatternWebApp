namespace BuilderPatternWebApp.Services
{
    public interface IPlanDirector
    {
        void SetPlanBuilder(IPlanBuilder planBuilder);

        void BuildBasicPlan();

        void BuildEnterprisePlan();
    }
}
