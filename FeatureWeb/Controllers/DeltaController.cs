using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;
using TestFeatureFlags;

namespace FeatureWeb.Controllers
{
    public class DeltaController : Controller
    {
        private readonly IFeatureManager _featureManager;

        public DeltaController(IFeatureManagerSnapshot featureManager) =>
            _featureManager = featureManager;

        [FeatureGate(MyFeatureFlags.Delta)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
