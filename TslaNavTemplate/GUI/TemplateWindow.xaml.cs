using System;
using System.Windows;
using TslaNavTemplate;

namespace GUI
{
    /// <summary>
    /// Interaction logic for TemplateWindow.xaml
    /// </summary>
    public partial class TemplateWindow : Window
    {
        public TemplateWindow()
        {
            InitializeComponent();
            Topmost = true;
        }

        private void BtnClickAddPanel(object sender, RoutedEventArgs e)
        {
            CustomPanel.AddCustomPanel("ID_TabHome");
        }

        private void BtnClickCheckDocuments(object sender, RoutedEventArgs e)
        {
            var docs = Autodesk.Navisworks.Api.Application.Documents;
            string info = "Currently opened documents: " + Environment.NewLine;
            foreach (var doc in docs)
            {
                info += doc.Title + Environment.NewLine;
            }
            MessageBox.Show(info);
        }
    }
}
