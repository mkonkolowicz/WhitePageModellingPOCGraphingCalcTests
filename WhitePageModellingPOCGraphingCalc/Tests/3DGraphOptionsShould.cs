using System;
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

        //First test using save button
        [Test]
        public void HaveASaveOption()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().SaveAccessible);
        }

        //Second test using save button
        [Test]
        public void HaveAFunctionalSaveMethod()
        {
            //Arrange & Act
            var threeDOptions = _mainWindow.Open3DParametricGraphOptionsMenu().SaveSettings();
            Assert.That(threeDOptions.FofX3DParametricEnabled);
        }

        [Test]
        public void HaveAResetOption()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().ResetAccessible);
        }

        //Example of a test testing logic, but third test using save button
        //This should be a test that is ran using an integration test. This is the case since the UI is not concerned with what it means to reset settings. The business logic does the work. 
        [Test]
        public void HaveAFunctionalResetMethod()
        {
            //Arrange
            const string uGridSectionsToModifyTo = "2";
            var threeDeeOptions = _mainWindow.Open3DParametricGraphOptionsMenu();
            var originalUGridSections = threeDeeOptions.CountOfUGridSections;
            var modifiedSettings = threeDeeOptions.EnteruGridSections(uGridSectionsToModifyTo);
            
            //Act
            var resetSettings = modifiedSettings.ResetSettings();
            
            //Assert
            Assert.That(string.CompareOrdinal(resetSettings.CountOfUGridSections, originalUGridSections)==0);
        }

        //fourth test using save button
        [Test]
        public void NotAllowForInputWhenInvalidSaveCriteria()
        {
            //Arrange
            const string uGridSectionsToModifyTo = "Invalid";
            var threeDeeOptions = _mainWindow.Open3DParametricGraphOptionsMenu();
            
            //Act
            var savedSettings = threeDeeOptions.SaveSettings();
            
            //Assert
            Assert.IsFalse(!savedSettings.FofX3DParametricEnabled());
        }

        [TearDown]
        public void TearDown()
        {
            AppWindow.Close();
        }
    }
}
