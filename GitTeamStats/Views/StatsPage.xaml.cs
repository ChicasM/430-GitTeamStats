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
    /// Interaction logic for StatsPage.xaml
    /// </summary>
    public partial class StatsPage : UserControl
    {
        public StatsPage()
        {
            InitializeComponent();
            testName.Text = "Milton Chicas";
            testEmail.Text = "ChicasM@ferris.edu";
            testStats.Text = "10 Commits \n12% Overall \n123 Additions \n600 Deletions";
        }


        private void FilterSavebtn_Click(object sender, RoutedEventArgs e)
        {
            FilterPanel.Visibility = Visibility.Hidden;
        }

        private void FilterBtn_Click(object sender, RoutedEventArgs e)
        {
            FilterPanel.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (graphHide.Visibility == Visibility.Visible)
            {
                graphHide.Visibility = Visibility.Hidden;
            }
            graphHide.Visibility = Visibility.Visible;
            
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).DataContext = new LaunchVM();
        }
    }
}
