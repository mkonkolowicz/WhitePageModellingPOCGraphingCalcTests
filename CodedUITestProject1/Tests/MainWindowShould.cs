using System.IO;
using CodedUIPageModellingPOCGraphingCalc.Models;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CodedUIPageModellingPOCGraphingCalc.Tests
{
    [TestFixture]
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

        [SetUp]
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
        [Test]
        public void ShowSin()
        {
            Assert.That(_mainWindow.ShowSinButton());
        }

        [Test]
        public void ShowCos()
        {
            Assert.That(_mainWindow.ShowCosButton());
        }

        [Test]
        public void NavigateTo2DGraphArea()
        {
            Assert.That(_mainWindow.Open2DGraphMenu().InputAreaVisible);
        }
        [Test]
        public void NotNavigateAwayFromMainAreaWhenNoneIsSelected()
        {
            Assert.That(_mainWindow.OpenNoneGraphMenu().ShowMainCalculatorInputArea);
        }
        [Test]
        public void NavigateToParametric2DGraphArea()
        {
            Assert.That(_mainWindow.Open2DGraphMenu().InputAreaVisible);
        }

        [Test]
        public void NavigateToParametric3DGraphArea()
        {
            Assert.That(_mainWindow.Open3DParametricGraphMenu().FofX3DParametricEnabled);
        }

        [TearDown]
        public void TearDown()
        {
            app.Close();
        }
    }
}
