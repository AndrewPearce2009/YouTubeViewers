using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.wpf.Commands;
using YouTubeViewers.wpf.Models;
using YouTubeViewers.wpf.Stores;

namespace YouTubeViewers.wpf.ViewModels
{
    public class EditYouTubeViewerViewModel : ViewModelsBase
    {
        public Guid YouTubeViewerId { get; }
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public EditYouTubeViewerViewModel(YouTubeViewer youTubeViewer, YouTubeViewersStore _youTubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            YouTubeViewerId = youTubeViewer.ID;

            ICommand submitCommand = new EditYouTubeViewerCommand(this, _youTubeViewersStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(submitCommand, cancelCommand)
            {
                Username = youTubeViewer.Username,
                IsSubscribed = youTubeViewer.IsSubscribed,
                IsMember = youTubeViewer.IsMember,
            };
        }
    }
}
