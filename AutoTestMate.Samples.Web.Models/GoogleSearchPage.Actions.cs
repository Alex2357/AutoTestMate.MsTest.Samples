﻿using AutoTestMate.MsTest.Infrastructure.Core;
using AutoTestMate.MsTest.Web.Core;
using AutoTestMate.MsTest.Web.Extensions;
using OpenQA.Selenium;

namespace AutoTestMate.Samples.Web.Models
{
    public partial class GoogleSearchPage : BasePage, IGoogleSearchPage
    {
        public GoogleSearchPage(IWebDriver driver, IConfigurationReader configurationReader, ILoggingUtility loggingUtility) : base(driver, configurationReader, loggingUtility)
        {
        }

        public GoogleSearchPage Open()
        {
            Driver.Navigate().GoToUrl(ConfigurationReader.GetConfigurationValue(MsTest.Web.Constants.Configuration.BaseUrlKey));
            return this;
        }

        public GoogleSearchPage AddSearchText(string text)
        {
            SearchTextBox.VisibleWait();
            SearchTextBox.Click();
            SearchTextBox.SendKeys(text);

            return this;
        }

        public GoogleSearchPage ClickSearchBox()
        {
            SearchTextBox.VisibleWait();
            SearchTextBox.Click();

            return this;
        }

        public GoogleSearchPage ClickSearchButton()
        {
            SearchButton.VisibleWait();
            SearchButton.Click();

            return this;
        }
    }
}
