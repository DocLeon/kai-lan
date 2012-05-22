using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coypu;
using TechTalk.SpecFlow;

namespace PageObjects.Features.step_definitions
{
    [Binding]
    public class PageActions_steps
    {
        private BrowserSession _browser;
        private string _examplePageUrl;
        private object _examplePage;

        [Given(@"I have a browser")]
        public void CreateBrowser()
        {
            _browser = new BrowserSession();
        }

        [Given(@"there is a static example page")]
        public void GivenThereIsAStaticExamplePage()
        {
            _examplePageUrl = "@static_page.html";
        }

        [When(@"I request the page")]
        public void WhenIRequestThePage()
        {
            on_page<Example_Page>(page => _examplePage = page);
        }

        [Then(@"I should receive a page object with the url of the static example page")]
        public void ThenIShouldReceiveAPageObjectWithTheUrlOfTheStaticExamplePage()
        {
            _examplePage.Url.ShouldBe(_examplePageUrl);
        }

    }
}
