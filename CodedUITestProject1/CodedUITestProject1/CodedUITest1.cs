using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        [Owner("nigurr")]
        [Priority(1)]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow browser = BrowserWindow.Launch(new Uri("http://google.co.in"));
            Playback.Wait(1000);
            browser.Close();
        }

        [TestMethod]
        [Owner("nigurr")]
        [Priority(2)]
        public void CodedUITestMethod2()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow browser = BrowserWindow.Launch(new Uri("http://bing.com"));
            Playback.Wait(1000);
            browser.Close();
        }


        [TestMethod]
        [Owner("nigurr")]
        [Priority(3)]
        public void CodedUITestMethod3()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow browser = BrowserWindow.Launch(new Uri("http://yahoo.com"));
            Playback.Wait(1000);
            browser.Close();
        }

        [TestMethod]
        [Owner("nigurr")]
        [Priority(4)]
        public void CodedUITestMethod4()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow browser = BrowserWindow.Launch(new Uri("http://news.ycombinator.com/"));
            Playback.Wait(1000);
            browser.Close();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
