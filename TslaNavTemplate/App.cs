using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;
using GUI;
using System.Windows.Forms;

namespace TslaNavTemplate
{

    [PluginAttribute("TslaTemplate", "TSLA", DisplayName = "Tesla template plugin")]
    //[AddInPluginAttribute(AddInLocation.AddIn, CallCanExecute = CallCanExecute.Always, CanToggle = true, Icon = "test.ico", LargeIcon = "test.ico", LoadForCanExecute = true, Shortcut = "XX", ShortcutWindowTypes = ")")]
    //[RibbonTabAttribute("Test Ribbon", CallCanExecute = CallCanExecute.Always, DisplayName = "Display test", LoadForCanExecute = true)]
    [DockPanePluginAttribute(100,100, AutoScroll = false, FixedSize = true, MinimumHeight =300, MinimumWidth = 250)]
    //public class App : AddInPlugin
    public class App : DockPanePlugin
    {
        #region Configuration and assembly version

#if     DEBUG2020 || RELEASE2020
        public const string AssemblyYear = "2020";
#elif   DEBUG2021 || RELEASE2021
        public const string AssemblyYear = "2021";
#elif   DEBUG2022 || RELEASE2022
        public const string AssemblyYear = "2022";
#endif
        //increment on every release build
        public const string AssemblyMinorVersion = "1"; //new functions
        public const string AssemblyRevisionVersion = "1"; //significant fixes and improvements
        public const string AssemblyBuildVersion = "1"; //small fixes and improvements

        public static string PlugInVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}",
                                AssemblyYear,
                                AssemblyMinorVersion,
                                AssemblyRevisionVersion,
                                AssemblyBuildVersion);
            }
        }
        #endregion

        public override Control CreateControlPane()
        {
            HelloWorldControl control = new HelloWorldControl();
            control.Dock = DockStyle.Fill;

            control.CreateControl();

            return control;
        }

        public override void DestroyControlPane(Control pane)
        {
            HelloWorldControl control = pane as HelloWorldControl;
            if (control != null)
            {
                control.Dispose();
            }
        }

        public override void OnActivePaneChanged(bool isActive)
        {
            base.OnActivePaneChanged(isActive);
        }

        public override void OnVisibleChanged()
        {
            base.OnVisibleChanged();
        }

        public override bool TryShowHelp()
        {
            return base.TryShowHelp();
        }

        public override bool TryShowHelpAtScreenPoint(int x, int y)
        {
            return base.TryShowHelpAtScreenPoint(x, y);
        }

        public override bool TryShowHelpForHighlight()
        {
            return base.TryShowHelpForHighlight();
        }

        public override IWin32Window CreateHWndPane(IWin32Window parent)
        {
            return base.CreateHWndPane(parent);
        }

        public override void DestroyHWndPane(IWin32Window pane)
        {
            base.DestroyHWndPane(pane);
        }


        protected override void OnLoaded()
        {
            base.OnLoaded();
        }

        protected override void OnUnloading()
        {
            base.OnUnloading();
        }

        protected override bool IsSelfEnabled()
        {
            return base.IsSelfEnabled();
        }
        //public override int Execute(params string[] parameters)
        //{          
        //    int resultCode = 0;            

        //    TemplateWindow window = new TemplateWindow();
        //    window.Show();         

        //    return resultCode;          
        //}
    }
}
