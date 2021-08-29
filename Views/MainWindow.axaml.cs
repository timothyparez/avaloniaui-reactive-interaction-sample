using System.Threading.Tasks;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaAppTemplate.Namespace;
using InteractionSample.ViewModels;
using ReactiveUI;

namespace InteractionSample.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WhenActivated(d => d(ViewModel!.ShowLoginWindowInteraction.RegisterHandler(HandleShowLoginWindowInteraction)));
        }

        private async Task HandleShowLoginWindowInteraction(InteractionContext<LoginWindowViewModel, LoginWindowViewModel> interaction)
        {            
            var loginWindow = new LoginWindow() { DataContext = interaction.Input };
            
            var updatedLoginWindowViewModel = await loginWindow.ShowDialog<LoginWindowViewModel>(this);
            interaction.SetOutput(updatedLoginWindowViewModel);            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}