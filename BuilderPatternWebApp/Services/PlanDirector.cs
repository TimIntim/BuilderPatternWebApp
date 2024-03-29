﻿namespace BuilderPatternWebApp.Services
{
    public class PlanDirector : IPlanDirector
    {
        private IPlanBuilder _builder;

        public void SetPlanBuilder(IPlanBuilder builder)
        {
            _builder = builder;
        }

        public void BuildBasicPlan()
        {
            _builder.BuildDiskSpaceFeature();
            _builder.BuildDatabaseFeature();
            _builder.BuildBandwidthFeature();
        }

        public void BuildEnterprisePlan()
        {
            _builder.BuildDiskSpaceFeature();
            _builder.BuildDatabaseFeature();
            _builder.BuildBandwidthFeature();
            _builder.BuildSslFeature();
        }
    }
}
