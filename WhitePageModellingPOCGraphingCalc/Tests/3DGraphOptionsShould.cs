using System.IO;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using WhitePageModellingPOCGraphingCalc.Models;

namespace WhitePageModellingPOCGraphingCalc.Tests
{
    [TestFixture]
    public class ThreeDeeParametricGraphOptionsShould
    {
        private const string LocalPathToTestApp = "C:\\Github\\WhitePageModellingPOCGraphingCalcTests\\GraphingCalculatorDemo\\bin\\Debug\\";
        private static string cwd = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string projectName = "GraphingCalculatorForWhitePOC"; 
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
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().ParentWindow.Enabled);
        }

        [Test]
        public void HaveUMinAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().uMinAccessible);
        }

        [Test]
        public void HaveUMaxAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().uMaxAccessible);
        }

        [Test]
        public void HaveUGridSectionsAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().uGridSectionsAccessible);
        }

        [Test]
        public void HaveVMinAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().vMinAccessible);
        }

        [Test]
        public void HaveVMaxAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().vMaxAccessible);
        }

        [Test]
        public void HaveVGridSectionsAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().vGridSectionsAccessible);
        }

        [TearDown]
        public void TearDown()
        {
            AppWindow.Close();
        }
    }
}
