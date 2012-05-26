using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coypu;
using Shouldly;
using TechTalk.SpecFlow;

namespace PageObjects.Features.step_definitions
{
    [Binding]
    public class PageActions_steps: PageObjectSteps
    {
        private BrowserSession _browser;
        private string _examplePageUrl;
        private Example_Page _examplePage;

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

    public class Example_Page: PageObject
    {
        public string Url { get; set; }
    }

    public class PageObjectSteps
    {
        protected void on_page<T>(Action<T> action) where T : PageObject
        {
              
        }
    }

    public class PageObject
    {
    }
}
