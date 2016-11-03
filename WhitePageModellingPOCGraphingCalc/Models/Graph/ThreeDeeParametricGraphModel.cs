using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace WhitePageModellingPOCGraphingCalc.Models.Graph
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

        #region Public Properties
        public bool FofX3DParametricAccessible => FofXInput3dParametric.Visible && FofXInput3dParametric.Enabled;
        public bool FofX3DParametricEnabled => FofXInput3dParametric.Enabled;
        public bool FofY3DParametricEnabled => FofYInput3dParametric.Enabled;
        
        public bool SphereEnabled => Sphere.Enabled;
        public bool ConeEnabled => Cone.Enabled;
        
        public bool TorusEnabled => Torus.Enabled;
        public bool SolidMeshEnabled => SolidMesh.Enabled;
        #endregion

    }
}