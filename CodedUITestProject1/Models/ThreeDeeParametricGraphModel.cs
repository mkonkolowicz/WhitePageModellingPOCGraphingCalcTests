using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;


namespace CodedUIPageModellingPOCGraphingCalc.Models
{
    public class ThreeDeeParametricGraphModel : TestHelper
    {
        public ThreeDeeParametricGraphModel(WpfWindow parentWindow) : base(parentWindow)
        {
        }

        #region Private Properties
        public WpfEdit FofXInput3dParametric
        {
            get
            {
                var edit = new WpfEdit();
                edit.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UIXt3dParametric";
                edit.Find();
                return edit;
            }
        }
        public WpfEdit FofYInput3dParametric
        {
            get
            {
                var edit = new WpfEdit();
                edit.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UIYt3dParametric";
                edit.Find();
                return edit;
            }
        }
        public WpfButton Sphere
        {
            get
            {
                var button = new WpfButton();
                button.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UISphere";
                button.Find();
                return button;
            }
        }
        public WpfButton Cone
        {
            get
            {
                var button = new WpfButton();
                button.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UICone";
                button.Find();
                return button;
            }
        }
        public WpfButton Torus
        {
            get
            {
                var button = new WpfButton();
                button.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UITorus";
                button.Find();
                return button;
            }
        }
        public WpfButton SolidMesh
        {
            get
            {
                var button = new WpfButton();
                button.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UISolidMesh";
                button.Find();
                return button;
            }
        }
        #endregion

        #region Public Methods
        public bool FofX3DParametricEnabled()
        {
            return FofXInput3dParametric.Enabled;
        }
        public bool FofY3DParametricEnabled()
        {
            return FofYInput3dParametric.Enabled;
        }
        public bool SphereEnabled()
        {
            return Sphere.Enabled;
        }
        public bool ConeEnabled()
        {
            return Cone.Enabled;
        }
        public bool TorusEnabled()
        {
            return Torus.Enabled;
        }
        public bool SolidMeshEnabled()
        {
            return SolidMesh.Enabled;
        }
        #endregion
    }
}