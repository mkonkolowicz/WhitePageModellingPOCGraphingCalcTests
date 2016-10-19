using System.IO;
using CUIPageModellingPOCGraphingCalc.Models;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUIPageModellingPOCGraphingCalc.Tests
{
    /// <summary>
    /// Summary description for MainWindowShould
    /// </summary>
    [CodedUITest]
    public class MainWindowShould
    {
        public MainWindowShould()
        {
        }

        private const string LocalPathToTestApp = "C:\\Github\\WhitePageModellingPOCGraphingCalcTests\\GraphingCalculatorDemo\\bin\\Debug\\";
        private static string cwd = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string projectName = "GraphingCalculatorForWhitePOC";  //YOUR PROJECT NAME HERE
        string solutionPath = cwd.Replace(projectName + "\\bin\\Debug", "");
        private static readonly string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        private static WpfWindow AppWindow;
        private ApplicationUnderTest app;
        private MainWindowModel _mainWindow;

        [TestInitialize]
        public void LaunchApp()
        {
            app = ApplicationUnderTest.Launch(LocalPathToTestApp + "GraphingCalculatorForWhitePOC.exe");
            var appWindow = new WpfWindow();
            appWindow.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UIMainWindow";

            _mainWindow = new MainWindowModel(AppWindow);
        }

        [TestMethod]
        public void Appear()
        {
            Assert.IsTrue(_mainWindow.ParentWindow.Enabled);
        }
        [TestMethod]
        public void ShowSin()
        {
            Assert.IsTrue(_mainWindow.ShowSinButton());
        }

        [TestMethod]
        public void ShowCos()
        {
            Assert.IsTrue(_mainWindow.ShowCosButton());
        }

        [TestMethod]
        public void NavigateTo2DGraphArea()
        {
            Assert.IsTrue(_mainWindow.Open2DGraphMenu().InputAreaVisible());
        }
        [TestMethod]
        public void NotNavigateAwayFromMainAreaWhenNoneIsSelected()
        {
            Assert.IsTrue(_mainWindow.OpenNoneGraphMenu().ShowMainCalculatorInputArea());
        }
        [TestMethod]
        public void NavigateToParametric2DGraphArea()
        {
            Assert.IsTrue(_mainWindow.Open2DGraphMenu().InputAreaVisible());
        }

        [TestMethod]
        public void NavigateToParametric3DGraphArea()
        {
            Assert.IsTrue(_mainWindow.Open3DParametricGraphMenu().FofX3DParametricEnabled());
        }

        [TestMethod]
        public void TestMethodTearDown()
        {
            app.Close();
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
