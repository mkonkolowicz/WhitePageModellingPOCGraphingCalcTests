using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CodedUIPageModellingPOCGraphingCalc
{
    public class TestHelper
    {
        protected internal WpfWindow ParentWindow { get; }

        public TestHelper(WpfWindow parentWindow)
        {
            ParentWindow = parentWindow;
        }
    }
}