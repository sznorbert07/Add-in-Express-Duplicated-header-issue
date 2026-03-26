using AddinExpress.OL;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Runtime.InteropServices;
using MyAddin1.Presenters;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace MyAddin1
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [GuidAttribute("5B0906D7-3FDA-4B5B-B5FC-BD38110CDF64"), ProgId("MyAddin1.AddinModule")]
    public partial class AddinModule : AddinExpress.MSO.ADXAddinModule
    {
        public AddinModule()
        {
            InitializeComponent();
            // Please add any initialization code to the AddinInitialize event handler
        }

        #region Add-in Express automatic code

        // Required by Add-in Express - do not modify
        // the methods within this region

        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }

        [ComRegisterFunctionAttribute]
        public static void AddinRegister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXRegister(t);
        }

        [ComUnregisterFunctionAttribute]
        public static void AddinUnregister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXUnregister(t);
        }

        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance
        {
            get
            {
                return AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            }
        }

        public Outlook._Application OutlookApp
        {
            get
            {
                return (HostApplication as Outlook._Application);
            }
        }

        private void OutlookEvents_ExplorerSelectionChange(object sender, object explorer)
        {
            RightReadingPanePresenter.Instance.UpdateView();
            ComposePanePresenter.Instance.UpdateView();
        }
    }
}

