using BuilderPatternWebApp.Models;

namespace BuilderPatternWebApp.Services
{
    public class BasicPlanBuilder : IPlanBuilder
    {
        public Plan Plan { get; set; } = new Plan();

        public BasicPlanBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Plan = new Plan() { Name = "Basic", Price = 19 };
        }

        public void BuildDiskSpaceFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Disk Space", Value = "1 GB" });
        }

        public void BuildDatabaseFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Database Size", Value = "5 GB" });
        }

        public void BuildBandwidthFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Bandwidth", Value = "10 GB" });
        }

        public void BuildSslFeature()
        {
            Plan.AddFeature(new Feature() { Title = "SSL", Value = "Not Free" });
        }

        public Plan GetPlan()
        {
            Plan result = Plan;
            
            Reset();

            return result;
        }
    }
}
