using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using WhitePageModellingPOCGraphingCalc.Models;

namespace WhitePageModellingPOCGraphingCalc.Tests
{
    [TestFixture]
    //Examples of basic UI tests.
    public class MainWindowShould
    {
        private const string LocalPathToTestApp = "C:\\Github\\WhitePageModellingPOCGraphingCalcTests\\GraphingCalculatorDemo\\bin\\Debug\\";
        private static Window _appWindow;
        private Application _app;
        private MainWindowModel _mainWindow;

        [SetUp]
        public void LaunchApp()
        {
            _app = Application.Launch(LocalPathToTestApp + "GraphingCalculatorForWhitePOC.exe");
            _appWindow= _app.GetWindow("MainWindow");
            _mainWindow = new MainWindowModel(_appWindow);
        }

        [Test]
        public void Appear()
        {
            Assert.That(_mainWindow.ParentWindow.Visible);
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
            Assert.That(_mainWindow.OpenNoneGraphMenu().ShowMainCalculatorInputArea,"Main calculator input area not shown if none option is selected and it should be");
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
            _appWindow.Close();
        }
    }
}
