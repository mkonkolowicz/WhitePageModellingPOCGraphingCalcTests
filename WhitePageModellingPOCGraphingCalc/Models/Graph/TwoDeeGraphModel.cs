using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc.Models.Graph
{
    public class TwoDeeGraphModel : TestHelper
    {
        public TwoDeeGraphModel(Window parentWindow) : base(parentWindow)
        {
        }
        
        #region Private Properties
        private TextBox FunctionInput => ParentWindow.Get<TextBox>("UIY");
        #endregion

        #region Public Methods
        public bool InputAreaVisible()
        {
            return FunctionInput.Visible;
        }
        #endregion

    }
}