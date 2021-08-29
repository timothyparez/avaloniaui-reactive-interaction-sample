using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace InteractionSample.Models
{
    public class User : ReactiveObject
    {
        [Reactive]
        public string? Name {get; set;}

        [Reactive]
        public string? Password {get; set;}


    }
}