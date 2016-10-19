using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc.Models
{
    public class ThreeDeeParametricGraphModel : TestHelper
    {
        public ThreeDeeParametricGraphModel(Window parentWindow) : base(parentWindow)
        {
        }

        #region Private Properties
        private TextBox FofXInput3dParametric => ParentWindow.Get<TextBox>("UIXt3dParametric");
        private TextBox FofYInput3dParametric => ParentWindow.Get<TextBox>("UIYt3dParametric");
        private Button Sphere => ParentWindow.Get<Button>("UISphere");
        private Button Cone => ParentWindow.Get<Button>("UICone");
        private Button Torus => ParentWindow.Get<Button>("UITorus");
        private Button SolidMesh => ParentWindow.Get<Button>("UISolidMesh");
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