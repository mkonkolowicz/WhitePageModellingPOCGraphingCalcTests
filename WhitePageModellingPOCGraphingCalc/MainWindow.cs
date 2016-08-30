using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems;

namespace WhitePageModellingPOCGraphingCalc
{
    [SetUpFixture]
    public class TestHelper
    {
        const string localPathToTestApp = "C:\\temp\\";
        public TestStack.White.UIItems.WindowItems.Window appWindow
        {
             
            get
            {
               return Application.Launch(localPathToTestApp+"GraphingCalculatorDemo.exe").GetWindow("MainWindow");
            }
        }
        public MainWindow window { get { return new MainWindow(); } } 
    }

    [TestFixture]
    public class MainWindowShould:TestHelper
    {
        [Test]
        public void Appear()
        {
            Assert.That(appWindow.Visible);
        }
        [Test]
        public void TurnsOff()
        {
            window.Off.Click();
            Assert.That(!window.Off.Enabled);
        }
    }

    public class MainWindow : TestHelper
    {
        public Button Off { get { return appWindow.Get<Button>("UIOff"); } }
    }
}
