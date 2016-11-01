using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc.Models
{
    public class ThreeDeeParametricGraphOptionsModel : TestHelper
    {
        public ThreeDeeParametricGraphOptionsModel(Window parentWindow) : base(parentWindow)
        {
        }

        #region Private Properties
        private TextBox uMin => ParentWindow.Get<TextBox>("UIuMin");
        private TextBox uMax => ParentWindow.Get<TextBox>("UIuMax");
        private TextBox uGridSections => ParentWindow.Get<TextBox>("UIuGrid");
        private TextBox vMin => ParentWindow.Get<TextBox>("UIvMin");
        private TextBox vMax => ParentWindow.Get<TextBox>("UIvMax");
        private TextBox vGridSections => ParentWindow.Get<TextBox>("UIuGridSections");
        private Button Save => ParentWindow.Get<Button>("UISaveOptions3d");
        private Button Reset => ParentWindow.Get<Button>("UIResetOptions3d");
        #endregion

        #region Public Properties
        public bool uMinAccessible => uMin.Visible && uMin.Enabled;
        public bool uMaxAccessible => uMax.Visible && uMax.Enabled;
        public bool uGridSectionsAccessible => uGridSections.Visible && uGridSections.Enabled;
        public bool vMinAccessible => vMin.Visible && vMin.Enabled;
        public bool vMaxAccessible => vMax.Visible && vMax.Enabled;
        public bool vGridSectionsAccessible => vGridSections.Visible && vGridSections.Enabled;

        #endregion

        #region Public Methods
        public ThreeDeeParametricGraphModel SaveSettings()
        {
            Save.Click();
            return new ThreeDeeParametricGraphModel(ParentWindow);
        }
        public ThreeDeeParametricGraphModel ResetSettings()
        {
            Save.Click();
            return new ThreeDeeParametricGraphModel(ParentWindow);
        }
        #endregion

    }
}