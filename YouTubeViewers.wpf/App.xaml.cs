using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YouTubeViewers.wpf.Stores;
using YouTubeViewers.wpf.ViewModels;

namespace YouTubeViewers.wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = new MainWindow
            {
                DataContext = new YouTubeViewersViewModel(_selectedYouTubeViewerStore)
            };

            MainWindow.Show();
        }
    }

}
