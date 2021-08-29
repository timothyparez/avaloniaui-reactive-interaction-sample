using System;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using InteractionSample.ViewModels;
using ReactiveUI;

namespace AvaloniaAppTemplate.Namespace
{
    public partial class LoginWindow : ReactiveWindow<LoginWindowViewModel>
    {
        public LoginWindow()
        {
            InitializeComponent(); 

            //This calls close and passes the result of the SubmitCommand to the Close method
            this.WhenActivated(d => d(ViewModel!.SubmitCommand.Subscribe(Close)));                        
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);            
        }
    }
}