using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive;
using System.Text;
using InteractionSample.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace InteractionSample.ViewModels
{
    public class LoginWindowViewModel : ViewModelBase
    {
        [Reactive]
        public User User {get ;set;}

        public ReactiveCommand<Unit, LoginWindowViewModel> SubmitCommand { get; set;}
        public LoginWindowViewModel()
        {
            User = new User();
            SubmitCommand = ReactiveCommand.Create(() => this);            
        }
    }
}