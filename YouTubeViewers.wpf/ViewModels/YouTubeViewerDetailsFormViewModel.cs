using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.wpf.ViewModels
{
    class YouTubeViewerDetailsFormViewModel : ViewModelsBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username; 
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private bool _isSubscribed;
        public bool IsSubscribed
        {
            get
            {
                return _isSubscribed;
            }

            set 
            {
               _isSubscribed = value;
                OnPropertyChanged(nameof(IsSubscribed));
            }
        }

        private bool _isMember;
        public bool IsMember
        {
            get
            {
                return _isMember;
            }

            set
            {
                _isMember = value; 
                OnPropertyChanged(nameof(IsMember));
            }
        }
    }
}
