using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc.Models
{
    public class TwoDeeParametricGraphModel : TestHelper
    {
        public TwoDeeParametricGraphModel(Window parentWindow) : base(parentWindow)
        {
        }

        #region Private Properties
        private TextBox FunctionInput => ParentWindow.Get<TextBox>("UIY");
        private Button GraphIt2D => ParentWindow.Get<Button>("UIGraphIt!");
        #endregion

        #region Public Methods
        public bool InputAreaEnabled()
        {
            return FunctionInput.Enabled;
        }

        public bool GraphItButtonEnabled()
        {
            return GraphIt2D.Enabled;
        }
        #endregion

    }
}