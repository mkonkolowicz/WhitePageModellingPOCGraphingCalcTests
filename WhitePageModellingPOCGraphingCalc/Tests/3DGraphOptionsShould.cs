using System.IO;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using WhitePageModellingPOCGraphingCalc.Models;

namespace WhitePageModellingPOCGraphingCalc.Tests
{
    [TestFixture]
    //Mostly UI testing examples, but some good examples of how model useage saves time in dev and what not to do :) Examples of Arrange Act Assert pattern, and failure messages. 
    public class ThreeDeeParametricGraphOptionsShould
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
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().ParentWindow.Enabled);
        }

        [Test]
        public void HaveUMinAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().UMinAccessible);
        }

        [Test]
        public void HaveUMaxAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().UMaxAccessible);
        }

        [Test]
        public void HaveUGridSectionsAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().UGridSectionsAccessible);
        }

        [Test]
        public void HaveVMinAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().VMinAccessible);
        }

        [Test]
        public void HaveVMaxAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().VMaxAccessible);
        }

        [Test]
        public void HaveVGridSectionsAvailableForInput()
        {
            Assert.That(_mainWindow.Open3DParametricGraphOptionsMenu().VGridSectionsAccessible);
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
            var resetCountOfGridSections = resetSettings.CountOfUGridSections;

            //Assert
            Assert.That(string.CompareOrdinal(resetCountOfGridSections, originalUGridSections)==0,$"The UGridSections text value was expected to be {originalUGridSections}, but was actually {resetCountOfGridSections} after hitting the reset button");
        }

        //Fourth test using save button
        [Test]
        public void NotAllowForInputWhenInvalidSaveCriteria()
        {
            //Arrange
            var threeDeeOptions = _mainWindow.Open3DParametricGraphOptionsMenu();
            threeDeeOptions.EnteruGridSections("TestInput");
            
            //Act
            var savedSettings = threeDeeOptions.SaveSettings();
            
            //Assert
            Assert.False(savedSettings.FofX3DParametricAccessible,"FofX3dParametric control is available for input, which means the modal alert that is supposed to block input has not been shown.");
            //app.kill is sent for this test only since there is a modal window which we can't get a hold of.
            _app.Kill();
        }

        [TearDown]
        public void TearDown()
        {
            _appWindow.Close();
        }
    }
}
