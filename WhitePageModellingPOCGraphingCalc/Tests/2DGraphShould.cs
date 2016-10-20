using System.IO;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using WhitePageModellingPOCGraphingCalc.Models;

namespace WhitePageModellingPOCGraphingCalc.Tests
{
    [TestFixture]
    public class TwoDeeParametricGraphShould
    {
        private const string LocalPathToTestApp = "C:\\Github\\WhitePageModellingPOCGraphingCalcTests\\GraphingCalculatorDemo\\bin\\Debug\\";
        private static string cwd = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string projectName = "GraphingCalculatorForWhitePOC";  //YOUR PROJECT NAME HERE
        string solutionPath = cwd.Replace(projectName + "\\bin\\Debug", "");
        private static readonly string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        private static Window AppWindow;
        private Application app;
        private MainWindowModel _mainWindow;

        [SetUp]
        public void LaunchApp()
        {
            app = Application.Launch(LocalPathToTestApp + "GraphingCalculatorForWhitePOC.exe");
            AppWindow= app.GetWindow("MainWindow");
            _mainWindow = new MainWindowModel(AppWindow);
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
            Assert.That(_mainWindow.Open2DParametricGraphMenu().SpiralEnabled);
        }

        [Test]
        public void HaveEllipseAvailableForAction()
        {
            Assert.That(_mainWindow.Open2DParametricGraphMenu().SpiralEnabled);
        }

        [Test]
        public void DoesNotShowSpiralAfterClickingGraphIt()
        {
            Assert.False(_mainWindow.Open2DParametricGraphMenu().GraphTheResult().SpiralEnabled);
        }

        [TearDown]
        public void TearDown()
        {
            AppWindow.Close();
        }
    }
}
