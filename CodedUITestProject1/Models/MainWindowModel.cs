using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;


namespace CodedUIPageModellingPOCGraphingCalc.Models
{
    public class MainWindowModel : TestHelper
    {
        public MainWindowModel(WpfWindow appWindow) : base(appWindow)
        {
        }

        #region Properties
        public WpfButton Sin {
            get
            {
                var button = new WpfButton();
                button.SearchProperties[WpfButton.PropertyNames.AutomationId] = "UISin";
                button.Find();
                return button;
            }
        }
        public WpfButton Cos
        {
            get
            {
                var button = new WpfButton();
                button.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UICos";
                button.Find();
                return button;
            }
        }
        public WpfMenu GraphMenu
        {
            get
            {
                var menu = new WpfMenu();
                menu.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UIGraphMenu";
                menu.Find();
                return menu;
            }
        }
        public WpfEdit MainCalculatorInputArea
        {
            get
            {
                var textbox = new WpfEdit();
                textbox.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UIGraphMenu";
                textbox.Find();
                return textbox;
            }
        }
        #endregion

        #region Public Methods
        public bool ShowSinButton()
        {
            return this.Sin.Enabled;
        }
        public bool ShowCosButton()
        {
            return this.Cos.Enabled;
        }
        public bool ShowMainCalculatorInputArea()
        {
            return MainCalculatorInputArea.Enabled;
        }
        public MainWindowModel OpenNoneGraphMenu()
        {
            var menuItem = GraphMenu.Items.ElementAt(0);
            Mouse.Click(GraphMenu);
            Mouse.Click(menuItem);
            return this;
        }
        public TwoDeeGraphModel Open2DGraphMenu()
        {
            var menuItem = GraphMenu.Items.ElementAt(1);
            Mouse.Click(GraphMenu);
            Mouse.Click(menuItem);
            return new TwoDeeGraphModel(ParentWindow);
        }
        public TwoDeeParametricGraphModel Open2DParametricGraphMenu()
        {
            var menuItem = GraphMenu.Items.ElementAt(2);
            Mouse.Click(GraphMenu);
            Mouse.Click(menuItem);
            return new TwoDeeParametricGraphModel(ParentWindow);
        }
        public ThreeDeeParametricGraphModel Open3DParametricGraphMenu()
        {
            var menuItem = GraphMenu.Items.ElementAt(3);
            Mouse.Click(GraphMenu);
            Mouse.Click(menuItem);
            return new ThreeDeeParametricGraphModel(ParentWindow);
        }
        #endregion
    }
}