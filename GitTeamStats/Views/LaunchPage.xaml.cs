using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using GitTeamStats.ViewModels;

namespace GitTeamStats.Views
{
    /// <summary>
    /// Interaction logic for LaunchPage.xaml
    /// </summary>
    public partial class LaunchPage : UserControl
    {
        public LaunchPage()
        {
            InitializeComponent();
        }

        private void BowseBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = openFileDialog.ShowDialog();
            if (result == true)
            {
                directoryTxt.Text = openFileDialog.FileName;
            }

        }

        private void ViewstatBtn_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).DataContext = new StatsVM();
        }
    }
}
