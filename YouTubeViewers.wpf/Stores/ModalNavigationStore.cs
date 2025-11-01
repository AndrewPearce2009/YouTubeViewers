using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.wpf.ViewModels;

namespace YouTubeViewers.wpf.Stores
{
    public class ModalNavigationStore
    {
        private ViewModelsBase _currentViewModel;
        public ViewModelsBase CurrentViewModel
        {
            get 
            {
                return _currentViewModel; 
            }

            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        public bool IsOpen => CurrentViewModel != null;

        public event Action CurrentViewModelChanged;

        public void Close()
        {
            CurrentViewModel = null;
        }
    }
}
