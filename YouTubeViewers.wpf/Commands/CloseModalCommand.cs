using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.wpf.Stores;

namespace YouTubeViewers.wpf.Commands
{
    public class CloseModalCommand : CommandBase
    {
        private readonly ModalNavigationStore modalNavigationStore;

        public CloseModalCommand(ModalNavigationStore modalNavigationStore)
        {
            this.modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            modalNavigationStore.Close();
        }
    }
}
