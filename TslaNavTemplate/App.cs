using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;
using GUI;

namespace TslaNavTemplate
{
    [PluginAttribute("TslaTemplate", "TSLA", DisplayName = "Tesla template plugin")]
    public class App : AddInPlugin
    {        
        public override int Execute(params string[] parameters)
        {          
            int resultCode = 0;

            TemplateWindow window = new TemplateWindow();
            window.ShowDialog();         

            return resultCode;
        }
    }
}
