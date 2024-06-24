using SpecFlowProject.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using TechTalk.SpecFlow.Infrastructure;

namespace SpecFlowProject.hooks
{
    [Binding]
    public sealed class SpecFlowHook
    {

        private ISpecFlowOutputHelper _outputHelper;

        public SpecFlowHook(ISpecFlowOutputHelper helper)
        {
            _outputHelper = helper;

        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Service.Instance.ValueRetrievers.Register(new ClothesSizeRetriver());
            Service.Instance.ValueComparers.Register(new ClothesSizeComparer());

            Service.Instance.ValueRetrievers.Unregister<BoolValueRetriever>();
            Service.Instance.ValueRetrievers.Register(new BooleanCustomRetriver());

            Service.Instance.ValueRetrievers.Register(new UsersRetriver());

            Service.Instance.ValueRetrievers.Register(new NullValueRetriever("<null>"));

            Service.Instance.ValueRetrievers.Register(new StoreCustomRetriver());
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Debug.WriteLine(nameof(AfterTestRun));

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {

            Debug.WriteLine(context.FeatureInfo.Title);
            Debug.WriteLine(context.FeatureInfo.Description);

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Debug.WriteLine(nameof(AfterFeature));

        }
        [BeforeScenario("example", "anotherExample")]
        public void BeforeScenario(ScenarioContext context)
        {
            _outputHelper.WriteLine(context.ScenarioInfo.Title);
            _outputHelper.WriteLine(context.ScenarioInfo.Description);
        }

        [AfterScenario]
        [Scope(Tag = "example")]
        [Scope(Tag = "anotherExample")]
        public void AfterScenario(ScenarioContext context)
        {
            _outputHelper.WriteLine(context.ScenarioInfo.Title);
            _outputHelper.WriteLine(context.ScenarioInfo.Description);
        }

    }
}
