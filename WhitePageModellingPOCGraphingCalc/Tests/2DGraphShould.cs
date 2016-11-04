using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using WhitePageModellingPOCGraphingCalc.Models;

namespace WhitePageModellingPOCGraphingCalc.Tests
{
    [TestFixture]
    //Basic UI test examples
    public class TwoDeeParametricGraphShould
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
        public void AppearWhenNavigatedTo()
        {
            Assert.That(_mainWindow.Open2DParametricGraphMenu().ParentWindow.Enabled);
        }

        [Test]
        public void HaveFofXAvailableForInput()
        {
            Assert.That(_mainWindow.Open2DParametricGraphMenu().FofXAreaEnabled);
        }

        [Test]
        public void HaveFofYAvailableForInput()
        {
            Assert.That(_mainWindow.Open2DParametricGraphMenu().FofYAreaEnabled);
        }

        [Test]
        public void HaveSpiralAvailableForAction()
        {
            Assert.That(_mainWindow.Open2DParametricGraphMenu().SpiralVisible);
        }

        [Test]
        public void HaveEllipseAvailableForAction()
        {
            Assert.That(_mainWindow.Open2DParametricGraphMenu().SpiralVisible);
        }

        [Test]
        public void NotShowSpiralAfterClickingGraphIt()
        {
            Assert.That(!(_mainWindow.Open2DParametricGraphMenu().GraphTheResult().SpiralVisible));
        }

        [TearDown]
        public void TearDown()
        {
            _appWindow.Close();
        }
    }
}
