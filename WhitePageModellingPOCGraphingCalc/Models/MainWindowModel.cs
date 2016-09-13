using TestStack.White.UIItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc.Models
{
    public class MainWindowModel : TestHelper
    {
        public MainWindowModel(Window appWindow) : base(appWindow)
        {
        }
        
        #region Properties
        private Button Sin => ParentWindow.Get<Button>("UISin");
        private Button Cos => ParentWindow.Get<Button>("UICos");
        private Menu GraphMenu => ParentWindow.Get<Menu>("UIGraphMenu");
        private TextBox MainCalculatorInputArea => ParentWindow.Get<TextBox>("UICalculationResults");
        #endregion
        
        #region Public Methods
        public bool ShowSinButton()
        {
            return this.Sin.Visible;
        }
        public bool ShowCosButton()
        {
            return this.Cos.Visible;
        }
        public bool ShowMainCalculatorInputArea()
        {
            return MainCalculatorInputArea.Enabled;
        }
        public MainWindowModel OpenNoneGraphMenu()
        {
            GraphMenu.ChildMenus.Find(x => x.Id == "UIGraphNone").Click();
            return this;
        }
        public TwoDeeGraphModel Open2DGraphMenu()
        {
            GraphMenu.ChildMenus.Find(x => x.Id == "UIGraph").Click();
            return new TwoDeeGraphModel(ParentWindow);
        }
        public TwoDeeParametricGraphModel Open2DParametricGraphMenu()
        {
            GraphMenu.ChildMenus.Find(x => x.Id == "UIGraph2D").Click();
            return new TwoDeeParametricGraphModel(ParentWindow);
        }
        public ThreeDeeParametricGraphModel Open3DParametricGraphMenu()
        {
            GraphMenu.ChildMenus.Find(x => x.Id == "UIGraph3D").Click();
            return new ThreeDeeParametricGraphModel(ParentWindow);
        }
        #endregion

    }
}