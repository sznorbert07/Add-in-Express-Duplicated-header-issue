using MyAddin1.Forms;

namespace MyAddin1.Presenters
{
    public class ComposePanePresenter : IPresenter
    {
        private static ComposePanePresenter _instance;

        private ComposePaneForm _form;

        public bool ShouldBeVisible = false;

        public static ComposePanePresenter Instance
        {
            get
            {
                return _instance ?? (_instance = new ComposePanePresenter());
            }
        }

        public void SetForm(ComposePaneForm form)
        {
            _form = form;
        }

        public void UpdateView()
        {
            if (ShouldBeVisible && _form.RegionState != AddinExpress.OL.ADXRegionState.Normal)
            {
                _form.Show();
                _form.RegionState = AddinExpress.OL.ADXRegionState.Normal;
            }
            
            if (!ShouldBeVisible && _form.RegionState != AddinExpress.OL.ADXRegionState.Hidden)
            {
                _form.Hide();
                _form.RegionState = AddinExpress.OL.ADXRegionState.Hidden;
            }
        }
    }
}
