using BuilderPatternWebApp.Models;

namespace BuilderPatternWebApp.Services
{
    public interface IPlanFluentBuilder
    {
        IPlanFluentBuilder BuildDiskSpaceFeature();
        IPlanFluentBuilder BuildDatabaseFeature();
        IPlanFluentBuilder BuildBandwidthFeature();
        IPlanFluentBuilder BuildSslFeature();

        Plan GetPlan();
    }
}
