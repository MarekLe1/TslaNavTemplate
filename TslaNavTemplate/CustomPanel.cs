using Autodesk.Windows;

namespace TslaNavTemplate
{
    public static class CustomPanel
    {
        public static void AddCustomPanel(string existingTabName)
        {
            foreach (RibbonTab Tab in ComponentManager.Ribbon.Tabs)
            {
                //get Home tab
                if (Tab.Id == "ID_TabHome")
                {
                    RibbonPanel tslaAdnPanel = new RibbonPanel();
                    //create ribbon panel source and bind it to the panel
                    RibbonPanelSource tslaAdnSource = new RibbonPanelSource();
                    tslaAdnSource.Id = "TSLA_AddinTemplatePanel";
                    tslaAdnSource.Name = "TSLA Panel";

                    tslaAdnPanel.Source = tslaAdnSource;

                    //create ribbon button
                    RibbonButton button = new RibbonButton();
                    button.IsEnabled = true;
                    button.IsVisible = true;
                    //button.Image = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"Images/ListAdd.png", UriKind.RelativeOrAbsolute));
                    //button.LargeImage = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"Images/open.png", UriKind.RelativeOrAbsolute));
                    button.ShowImage = true;
                    button.Size = RibbonItemSize.Standard;
                    button.ShowText = true;
                    button.ResizeStyle = RibbonItemResizeStyles.HideText;
                    button.Id = "TSLA_ButtonId";
                    button.Name = "TslaButtonName";
                    button.Text = "TeslaButton";
                    button.Orientation = System.Windows.Controls.Orientation.Vertical;
                    button.CommandHandler = new TestCommand();


                    //add the button to the panel
                    tslaAdnPanel.Source.Items.Add(button);
                    //delegate the event when ribbon element is activated
                    //ComponentManager.UIElementActivated += new EventHandler(ComponentManager_UIElementActivated);
                    //add the panel to the tab

                    Tab.Panels.Add(tslaAdnPanel);
                }
            }
        }
    }
}
