using CodedUIPageModellingPOCGraphingCalc;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUIPageModellingPOCGraphingCalc.Models
{
    public class TwoDeeParametricGraphModel : TestHelper
    {
        public TwoDeeParametricGraphModel(WpfWindow parentWindow) : base(parentWindow)
        {
        }

        #region Private Properties
        private WpfEdit FunctionInput
        {
            get
            {
                var edit = new WpfEdit();
                edit.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UIY";
                edit.Find();
                return edit;
            }
        }
        private WpfButton GraphIt2D
        {
            get
            {
                var button = new WpfButton();
                button.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UIGraphIt!";
                button.Find();
                return button;
            }
        }
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