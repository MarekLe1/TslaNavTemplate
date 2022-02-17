using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;
using GUI;

namespace TslaNavTemplate
{

    [PluginAttribute("TslaTemplate", "TSLA", DisplayName = "Tesla template plugin")]
    //[AddInPluginAttribute(AddInLocation.AddIn, CallCanExecute = CallCanExecute.Always, CanToggle = true, Icon = "test.ico", LargeIcon = "test.ico", LoadForCanExecute = true, Shortcut = "XX", ShortcutWindowTypes = ")")]
    //[RibbonTabAttribute("Test Ribbon", CallCanExecute = CallCanExecute.Always, DisplayName = "Display test", LoadForCanExecute = true)]

    public class App : AddInPlugin
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
        public App()
        {

        }

        public override int Execute(params string[] parameters)
        {          
            int resultCode = 0;            
            
            TemplateWindow window = new TemplateWindow();
            window.Show();         

            return resultCode;          
        }
    }
}
