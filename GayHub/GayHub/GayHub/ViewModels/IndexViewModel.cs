using Prism.Commands;
using Prism.Mvvm; 

namespace GayHub.ViewModels
{
    public class IndexViewModel : BindableBase
    {
        public DelegateCommand AppearingCommand { get; private set; }
        public IndexViewModel()
        {
            AppearingCommand = new DelegateCommand(Appearing);
        }

        private void Appearing()
        {

        }
    }
}
