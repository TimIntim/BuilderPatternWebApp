using BuilderPatternWebApp.Models;

namespace BuilderPatternWebApp.Services
{
    public interface IPlanBuilder
    {
        void BuildDiskSpaceFeature();
        void BuildDatabaseFeature();
        void BuildBandwidthFeature();
        void BuildSslFeature();

        Plan GetPlan();
    }
}
