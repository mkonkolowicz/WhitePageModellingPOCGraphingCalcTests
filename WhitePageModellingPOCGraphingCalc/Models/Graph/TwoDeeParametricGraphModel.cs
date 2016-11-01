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
        private TextBox FofX => ParentWindow.Get<TextBox>("UIXt2dParametric");
        private TextBox FofY => ParentWindow.Get<TextBox>("UIYt2dParametric");
        private Button Spiral => ParentWindow.Get<Button>("UISpiral");
        private Button Ellipse => ParentWindow.Get<Button>("UIEllipse");
        private Button GraphIt => ParentWindow.Get<Button>("UIGraphIt!2DParametric");
        #endregion
        
        #region Public Properties
        public bool SpiralVisible => Spiral.Visible;
        public bool FofXAreaEnabled => FofX.Enabled;
        public bool FofYAreaEnabled => FofY.Enabled;
        public bool EllipseEnabled => Ellipse.Enabled;
        public bool GraphitButtonEnabled => GraphIt.Enabled;
        #endregion
        
        #region Public Methods
        public TwoDeeParametricGraphModel GraphTheResult()
        {
            GraphIt.Click();
            return this;
        }
        #endregion

    }
}