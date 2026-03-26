namespace MyAddin1
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinModule));
            this.adxOlFormsManager1 = new AddinExpress.OL.ADXOlFormsManager(this.components);
            this.ExplorerRightReadingPane = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.ComposePane = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.OutlookEvents = new AddinExpress.MSO.ADXOutlookAppEvents(this.components);
            // 
            // adxOlFormsManager1
            // 
            this.adxOlFormsManager1.Items.Add(this.ExplorerRightReadingPane);
            this.adxOlFormsManager1.Items.Add(this.ComposePane);
            this.adxOlFormsManager1.SetOwner(this);
            // 
            // ExplorerRightReadingPane
            // 
            this.ExplorerRightReadingPane.Cached = AddinExpress.OL.ADXOlCachingStrategy.OneInstanceForAllFolders;
            this.ExplorerRightReadingPane.ExplorerItemTypes = AddinExpress.OL.ADXOlExplorerItemTypes.olMailItem;
            this.ExplorerRightReadingPane.ExplorerLayout = AddinExpress.OL.ADXOlExplorerLayout.RightReadingPane;
            this.ExplorerRightReadingPane.FormClassName = "MyAddin1.Forms.RightReadingPaneForm";
            this.ExplorerRightReadingPane.InspectorItemTypes = AddinExpress.OL.ADXOlInspectorItemTypes.olMail;
            this.ExplorerRightReadingPane.InspectorLayout = AddinExpress.OL.ADXOlInspectorLayout.RightSubpane;
            this.ExplorerRightReadingPane.InspectorMode = AddinExpress.OL.ADXOlInspectorMode.Read;
            this.ExplorerRightReadingPane.IsHiddenStateAllowed = false;
            // 
            // ComposePane
            // 
            this.ComposePane.Cached = AddinExpress.OL.ADXOlCachingStrategy.OneInstanceForAllFolders;
            this.ComposePane.ExplorerItemTypes = AddinExpress.OL.ADXOlExplorerItemTypes.olMailItem;
            this.ComposePane.ExplorerLayout = AddinExpress.OL.ADXOlExplorerLayout.RightReadingPane;
            this.ComposePane.FormClassName = "MyAddin1.Forms.ComposePaneForm";
            this.ComposePane.InspectorItemTypes = AddinExpress.OL.ADXOlInspectorItemTypes.olMail;
            this.ComposePane.InspectorLayout = AddinExpress.OL.ADXOlInspectorLayout.RightSubpane;
            this.ComposePane.InspectorMode = AddinExpress.OL.ADXOlInspectorMode.Compose;
            this.ComposePane.IsHiddenStateAllowed = false;
            // 
            // OutlookEvents
            // 
            this.OutlookEvents.HandleEvents = ((AddinExpress.MSO.ADXOutlookAppEvents.HandledOutlookEvents)(resources.GetObject("OutlookEvents.HandleEvents")));
            this.OutlookEvents.ExplorerSelectionChange += new AddinExpress.MSO.ADXOlExplorer_EventHandler(this.OutlookEvents_ExplorerSelectionChange);
            // 
            // AddinModule
            // 
            this.AddinName = "MyAddin1";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaOutlook;

        }
        #endregion

        private AddinExpress.OL.ADXOlFormsManager adxOlFormsManager1;
        private AddinExpress.OL.ADXOlFormsCollectionItem ExplorerRightReadingPane;
        internal AddinExpress.MSO.ADXOutlookAppEvents OutlookEvents;
        private AddinExpress.OL.ADXOlFormsCollectionItem ComposePane;
    }
}

