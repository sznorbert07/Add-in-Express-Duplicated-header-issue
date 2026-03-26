using MyAddin1.Forms;

namespace MyAddin1.Presenters
{
    public class RightReadingPanePresenter : IPresenter
    {
        private static RightReadingPanePresenter _instance;

        private RightReadingPaneForm _form;

        public bool ShouldBeVisible = true;

        public static RightReadingPanePresenter Instance
        {
            get
            {
                return _instance ?? (_instance = new RightReadingPanePresenter());
            }
        }

        public void SetForm(RightReadingPaneForm form)
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
