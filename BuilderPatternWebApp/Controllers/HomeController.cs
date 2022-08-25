using BuilderPatternWebApp.Models;
using BuilderPatternWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BuilderPatternWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanDirector _director;

        public HomeController(IPlanDirector director)
        {
            _director = director;
        }

        public IActionResult Index()
        {
            PricingPlansModel model = new PricingPlansModel();

            var basicPlanBuilder = new BasicPlanBuilder();
            _director.SetPlanBuilder(basicPlanBuilder);
            _director.BuildBasicPlan();
            model.BasicPlan = basicPlanBuilder.GetPlan();

            var enterprisePlanBuilder = new EnterprisePlanBuilder(); 
            _director.SetPlanBuilder(enterprisePlanBuilder);
            _director.BuildEnterprisePlan();
            model.EnterprisePlan = enterprisePlanBuilder.GetPlan();

            var customPlanBuilder = new BasicPlanBuilder();
            customPlanBuilder.BuildDiskSpaceFeature();
            customPlanBuilder.BuildBandwidthFeature();
            model.CustomPlan = customPlanBuilder.GetPlan();

            return View(model);
        }
    }
}
