using BuilderPatternWebApp.Models;

namespace BuilderPatternWebApp.Services
{
    public class CustomPlanFluentBuilder : IPlanFluentBuilder
    {
        public Plan Plan { get; set; } = new Plan();

        public CustomPlanFluentBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Plan = new Plan() { Name = "Custom", Price = 19 };
        }

        public IPlanFluentBuilder BuildDiskSpaceFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Disk Space", Value = "5 GB" });
            return this;
        }

        public IPlanFluentBuilder BuildDatabaseFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Database Size", Value = "10 GB" });
            return this;
        }

        public IPlanFluentBuilder BuildBandwidthFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Bandwidth", Value = "50 GB" });
            return this;
        }

        public IPlanFluentBuilder BuildSslFeature()
        {
            Plan.AddFeature(new Feature() { Title = "SSL", Value = "Unlimited" });
            return this;
        }

        public Plan GetPlan()
        {
            Plan result = Plan;

            Reset();

            return result;
        }
    }
}
