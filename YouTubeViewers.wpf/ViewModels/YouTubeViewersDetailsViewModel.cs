using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.wpf.Models;
using YouTubeViewers.wpf.Stores;

namespace YouTubeViewers.wpf.ViewModels
{
    public class YouTubeViewersDetailsViewModel : ViewModelsBase
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;
        private YouTubeViewer SelectedYouTubeViewer => _selectedYouTubeViewerStore.SelectedYouTubeViewer;

        public bool HasSelectedYouTubeViewer => SelectedYouTubeViewer != null;
        public string Username => SelectedYouTubeViewer?.Username ?? "Not Provided";
        public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";
        public string IsMemberDisplay => (SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No";

        public YouTubeViewersDetailsViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {
           _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
        }
    }
}
