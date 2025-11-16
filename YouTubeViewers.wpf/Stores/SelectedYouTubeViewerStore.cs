using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Models;

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
            _youTubeViewerStore.YouTubeViewerAdded += _youTubeViewerStore_YouTubeViewerAdded;
        }

        private void _youTubeViewerStore_YouTubeViewerAdded(YouTubeViewer youTubeViewer)
        {
            SelectedYouTubeViewer = youTubeViewer;
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
