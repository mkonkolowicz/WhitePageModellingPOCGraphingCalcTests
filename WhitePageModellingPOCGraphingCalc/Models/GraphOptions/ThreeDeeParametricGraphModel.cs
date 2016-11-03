using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using WhitePageModellingPOCGraphingCalc.Models.Graph;

namespace WhitePageModellingPOCGraphingCalc.Models.GraphOptions
{
    public class ThreeDeeParametricGraphOptionsModel : TestHelper
    {
        public ThreeDeeParametricGraphOptionsModel(Window parentWindow) : base(parentWindow)
        {
        }

        #region Private Properties
        private TextBox UMin => ParentWindow.Get<TextBox>("UIuMin");
        private TextBox UMax => ParentWindow.Get<TextBox>("UIuMax");
        private TextBox UGridSections => ParentWindow.Get<TextBox>("UIuGrid");
        private TextBox VMin => ParentWindow.Get<TextBox>("UIvMin");
        private TextBox VMax => ParentWindow.Get<TextBox>("UIvMax");
        private TextBox VGridSections => ParentWindow.Get<TextBox>("UIuGridSections");
        private Button Save => ParentWindow.Get<Button>("UISaveOptions3d");
        private Button Reset => ParentWindow.Get<Button>("UIResetOptions3d");
        #endregion

        #region Public Properties
        public bool UMinAccessible => UMin.Visible && UMin.Enabled;
        public bool UMaxAccessible => UMax.Visible && UMax.Enabled;
        public bool UGridSectionsAccessible => UGridSections.Visible && UGridSections.Enabled;
        public bool VMinAccessible => VMin.Visible && VMin.Enabled;
        public bool VMaxAccessible => VMax.Visible && VMax.Enabled;
        public bool VGridSectionsAccessible => VGridSections.Visible && VGridSections.Enabled;
        public bool SaveAccessible => Save.Visible && Save.Enabled;
        public bool ResetAccessible => Reset.Visible && Reset.Enabled;
        public string CountOfUGridSections => UGridSections.Text;

        #endregion

        #region Public Methods
        public ThreeDeeParametricGraphModel SaveSettings()
        {
            Save.Click();
            return new ThreeDeeParametricGraphModel(ParentWindow);
        }
        public ThreeDeeParametricGraphOptionsModel ResetSettings()
        {
            Reset.Click();
            return this;
        }

        public ThreeDeeParametricGraphOptionsModel EnteruGridSections(string sections)
        {
            UGridSections.BulkText = sections.ToString();
            return this;
        }

        #endregion

    }
}