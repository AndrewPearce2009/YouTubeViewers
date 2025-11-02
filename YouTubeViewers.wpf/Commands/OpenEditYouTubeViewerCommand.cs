using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.wpf.Models;
using YouTubeViewers.wpf.Stores;
using YouTubeViewers.wpf.ViewModels;

namespace YouTubeViewers.wpf.Commands
{
    public class OpenEditYouTubeViewerCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        public YouTubeViewersListingItemViewModel _youTubeViewersListingItemViewModel { get; }
        public YouTubeViewersStore _youTubeViewersStore { get; }

        public OpenEditYouTubeViewerCommand(YouTubeViewersListingItemViewModel youTubeViewersListingItemViewModel, 
            YouTubeViewersStore youTubeViewersStore, 
            ModalNavigationStore modalNavigationStore)
        {
            _youTubeViewersListingItemViewModel = youTubeViewersListingItemViewModel;
            _youTubeViewersStore = youTubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            YouTubeViewer youTubeViewer = _youTubeViewersListingItemViewModel.YouTubeViewer;

            EditYouTubeViewerViewModel editYouTubeViewerViewModel =
                new EditYouTubeViewerViewModel(youTubeViewer, _youTubeViewersStore, _modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = editYouTubeViewerViewModel;
        }
    }
}
