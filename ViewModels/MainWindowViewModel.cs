using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using InteractionSample.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace InteractionSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {                
        [Reactive]
        public User? User {get; set;}        

        public ReactiveCommand<Unit, Unit> LoginCommand {get; set;}

        public Interaction<LoginWindowViewModel, LoginWindowViewModel> ShowLoginWindowInteraction { get;}


        public MainWindowViewModel()
        {            
            LoginCommand = ReactiveCommand.CreateFromTask<Unit, Unit>(LoginCommand_Execute);
            ShowLoginWindowInteraction = new Interaction<LoginWindowViewModel, LoginWindowViewModel>();
        }
       
        private async Task<Unit> LoginCommand_Execute(Unit arg)
        {            
            var loginWindowViewModel = new LoginWindowViewModel();
            var updatedLoginWindowViewModel = await ShowLoginWindowInteraction.Handle(loginWindowViewModel);

            if (updatedLoginWindowViewModel != null)
            {
                User = updatedLoginWindowViewModel.User;
            }
            else
            {
                //The user cancelled
            }
            
            return Unit.Default;
        }
    }
}
