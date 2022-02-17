using Autodesk.Windows;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace TslaNavTemplate
{
    public static class CustomPanel
    {
        private static BitmapSource GetEmbeddedImage(string name)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                System.IO.Stream stream = assembly.GetManifestResourceStream(name);
                return BitmapFrame.Create(stream);
            }
            catch
            {
                return null;
            }


        }

        public static void AddCustomPanel(string existingTabName)
        {
            foreach (RibbonTab Tab in ComponentManager.Ribbon.Tabs)
            {
                //get Home tab
                if (Tab.Id == existingTabName)
                {
                    RibbonPanel tslaAdnPanel = new RibbonPanel();
                    //create ribbon panel source and bind it to the panel
                    RibbonPanelSource tslaAdnSource = new RibbonPanelSource();
                    tslaAdnSource.Id = "TSLA_AddinTemplatePanel";
                    tslaAdnSource.Name = "Tesla Plugin";
                    tslaAdnSource.Title = "Tesla Tools";
                    
                    tslaAdnPanel.ResizeStyle = RibbonResizeStyles.NeverHideText;
                    tslaAdnPanel.Source = tslaAdnSource;

                    //create ribbon button
                    RibbonButton button1 = new RibbonButton();
                    button1.IsEnabled = true;
                    button1.IsVisible = true;
                    button1.Image = GetEmbeddedImage("Resources.tesla_icon_active.png");
                    button1.LargeImage = GetEmbeddedImage("Resources.tesla_icon_active.png");
                    button1.ShowImage = true;
                    button1.Size = RibbonItemSize.Large;
                    button1.ShowText = true;
                    button1.ResizeStyle = RibbonItemResizeStyles.ChangeSize;
                    button1.Id = "TSLA_ButtonId1";
                    button1.Name = "TslaButtonName1";
                    button1.Text = "TeslaButton1";
                    button1.Orientation = System.Windows.Controls.Orientation.Vertical;
                    button1.CommandHandler = new TestCommand();

                    RibbonButton button2 = new RibbonButton();
                    button2.IsEnabled = true;
                    button2.IsVisible = true;
                    button2.Image = GetEmbeddedImage("Resources.tesla_icon_active.png");
                    button2.LargeImage = GetEmbeddedImage("Resources.tesla_icon_active.png");
                    button2.ShowImage = true;
                    button2.Size = RibbonItemSize.Large;
                    button2.ShowText = true;
                    button2.ResizeStyle = RibbonItemResizeStyles.ChangeSize;
                    button2.Id = "TSLA_ButtonId2";
                    button2.Name = "TslaButtonName2";
                    button2.Text = "TeslaButton2";
                    button2.Orientation = System.Windows.Controls.Orientation.Vertical;
                    button2.CommandHandler = new TestCommand();


                    //add the button to the panel
                    tslaAdnPanel.Source.Items.Add(button1);
                    tslaAdnPanel.Source.Items.Add(button2);
                    //delegate the event when ribbon element is activated
                    //ComponentManager.UIElementActivated += new EventHandler(ComponentManager_UIElementActivated);
                    //add the panel to the tab

                    Tab.Panels.Add(tslaAdnPanel);
                }
            }
        }
    }
}
