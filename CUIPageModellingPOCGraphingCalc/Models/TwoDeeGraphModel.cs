using CodedUIPageModellingPOCGraphingCalc;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUIPageModellingPOCGraphingCalc.Models
{
    public class TwoDeeGraphModel : TestHelper
    {
        public TwoDeeGraphModel(WpfWindow parentWindow) : base(parentWindow)
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
        #endregion

        #region Public Methods
        public bool InputAreaVisible()
        {
            return FunctionInput.Enabled;
        }
        #endregion
    }
}