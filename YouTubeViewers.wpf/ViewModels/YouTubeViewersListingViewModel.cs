using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.wpf.Stores;

namespace YouTubeViewers.wpf.ViewModels
{
    public class YouTubeViewersListingViewModel : ViewModelsBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;

        public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Greg"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Emma"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Terry"));
        }
    }
}
