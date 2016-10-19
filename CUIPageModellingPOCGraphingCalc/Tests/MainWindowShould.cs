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
    }
}
