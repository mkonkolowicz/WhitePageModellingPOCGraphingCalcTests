using NUnit.Framework;
using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc
{
    public class TestHelper
    {
        const string localPathToTestApp = "C:\\temp\\";
        private static Application app = Application.Launch(localPathToTestApp + "GraphingCalculatorDemo.exe");
        public static Window appWindow = app.GetWindow("MainWindow");
    }   

    [TestFixture]
    public class MainWindowShould:TestHelper
    {
        private MainWindowModel mainWindow = new MainWindowModel();

        [Test]
        public void Appear()
        {
            Assert.That(appWindow.Visible);
        }
        [Test]
        public void ShowSin()
        {
            Assert.That(mainWindow.Sin.Visible);
        }

        [Test]
        public void ShowTan()
        {
            Assert.That(mainWindow.Sin.Visible);
        }

        [Test]
        public void ShowCos()
        {
            Assert.That(mainWindow.Sin.Visible);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            appWindow.Close();
        }
    }

    public class MainWindowModel : TestHelper
    {
        public Button Off { get { return appWindow.Get<Button>("UIOff"); } }
        public Button Sin { get { return appWindow.Get<Button>("UIAppendSin"); } }
        public Button Cos { get { return appWindow.Get<Button>("UIAppendCos"); } }
        public Button Tan { get { return appWindow.Get<Button>("UIAppendTan"); } }
    }
}
