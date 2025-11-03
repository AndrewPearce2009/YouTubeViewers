using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.wpf.Models;

namespace YouTubeViewers.wpf.Stores
{
    public class SelectedYouTubeViewerStore
    {
        private readonly YouTubeViewersStore _youTubeViewerStore;

        private YouTubeViewer _selectedYouTubeViewer;
        public YouTubeViewer SelectedYouTubeViewer
        {
            get
            {
                return _selectedYouTubeViewer;
            }
            set
            {
                _selectedYouTubeViewer = value;
                SelectedYouTubeViewerChanged?.Invoke();
            }
        }

        public event Action SelectedYouTubeViewerChanged;

        public SelectedYouTubeViewerStore(YouTubeViewersStore youTubeViewerStore)
        {
            _youTubeViewerStore = youTubeViewerStore;

            _youTubeViewerStore.YouTubeViewerUpdated += _youTubeViewerStore_YouTubeViewerUpdated;
        }

        private void _youTubeViewerStore_YouTubeViewerUpdated(YouTubeViewer youTubeViewer)
        {
            if(youTubeViewer.ID == SelectedYouTubeViewer?.ID)
            {
                SelectedYouTubeViewer = youTubeViewer;
            }
        }
    }
}
