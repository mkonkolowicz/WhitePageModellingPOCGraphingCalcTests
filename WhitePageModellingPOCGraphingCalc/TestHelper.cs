using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc
{
    public class TestHelper
    {
        protected internal Window ParentWindow { get; }

        public TestHelper(Window parentWindow)
        {
            ParentWindow = parentWindow;
        }
    }
}