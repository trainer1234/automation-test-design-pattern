using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FluentAssertions.Equivalency;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

namespace ATDP.Core
{
    public enum BrowserTypes
    {
        Chrome,
        Firefox,
        Edge,
        IE,
        Safari
    }

    public static class Driver
    {
        private static WebDriverWait browserWait;
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }

                return browser;
            }
            private set => browser = value;
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browser == null || browserWait == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }

                return browserWait;
            }
            private set => browserWait = value;
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeout = 30)
        {
            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    var chromeOptions = new ChromeOptions();
                    Browser = new ChromeDriver(Path.Join(AppDomain.CurrentDomain.BaseDirectory, "drivers"));
                    Browser.Manage().Window.Maximize();
                    break;
                case BrowserTypes.Firefox:
                    Browser = new FirefoxDriver();
                    break;
                case BrowserTypes.Safari:
                    Browser = new SafariDriver();
                    break;
                case BrowserTypes.Edge:
                    Browser = new EdgeDriver();
                    break;
                case BrowserTypes.IE:
                    Browser = new InternetExplorerDriver();
                    break;
            }
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTimeout))
            {
                PollingInterval = TimeSpan.FromSeconds(2)
            };
            BrowserWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public static void StopBrowser()
        {
            Browser?.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
