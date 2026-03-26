using System;
using System.Drawing;
using AddinExpress.OL;
using MyAddin1.Presenters;

namespace MyAddin1.Forms
{
    public sealed partial class RightReadingPaneForm : ADXOlForm
    {
        private const int MINIMUM_WIDTH = 320;
        private const int MINIMUM_HEIGHT = 320;

        public RightReadingPaneForm()
        {
            InitializeComponent();

            ADXSplitterMove += OnAdxSplitterMove;

            Disposed += OnDisposed;
            ADXBeforeFormShow += OnBeforeFormShow;

            // Store the form so we can toggle visibility when inline response mode is enabled
            RightReadingPanePresenter.Instance.SetForm(this);
        }

        private void OnBeforeFormShow()
        {
                MinimumSize = new Size(MINIMUM_WIDTH, MINIMUM_HEIGHT);
                Width = MINIMUM_WIDTH;
        }

        private void OnDisposed(object sender, EventArgs eventArgs)
        {
            ADXSplitterMove -= OnAdxSplitterMove;

            Disposed -= OnDisposed;
            ADXBeforeFormShow -= OnBeforeFormShow;
        }

        private void OnAdxSplitterMove(object sender, ADXSplitterMoveEventArgs args)
        {
            if (args.NewRegionSize.Width < MINIMUM_WIDTH)
            {
                args.Cancel = true;
            }
        }
        public void EnablePane()
        {
            Show();
        }

        public void DisablePane()
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
