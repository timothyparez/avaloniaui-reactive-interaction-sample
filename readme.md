## ReactiveUI Interactions and AvaloniaUI

### Introduction
New [AvaloniaUI](https://www.avaloniaui.net) users often struggle dealing with Dialogs and returning results from Dialogs. The documentation does include [a nice sample](https://docs.avaloniaui.net/tutorials/music-store-app/opening-a-dialog) but I wanted to provide a bare minimum example on how to use [ReactiveUI Interactions](https://www.reactiveui.net/docs/handbook/interactions/) with AvaloniaUI.

### The sample
The sample has a `MainWindow` with a login `Button`.   
When you click the `Button` a `LoginWindow` is shown where you can input a `username` and `password`.  
Upon closing the `LoginWindow` an instance of `User` is returned to the `MainWindow`   
The `MainWindow` simply displays the `Name` of the `User` that was returned.

![screenshot](/home/timothy/Documents/Projects/InteractionSample/screenshot.png)
  
Basically the sample answers the question posed in the code below:

```csharp
public class MainWindowViewModel : ViewModelBase
{                
	[Reactive]
	public User? User {get; set;}        

	public ReactiveCommand<Unit, Unit> LoginCommand {get; set;}
	
	public MainWindowViewModel()
	{            
		LoginCommand = ReactiveCommand.CreateFromTask<Unit, Unit>(LoginCommand_Execute);		
	}

	private async Task<Unit> LoginCommand_Execute(Unit arg)
	{
		/* How do you replace this with something that will
		 * show a LoginWindow to get a new User */
		User = new User() { Name = "Batman", Password = "JokerIsMyFriend" }; 		
		return Unit.Default;
	}
}
```

### Architecture
While browsing through the code, the following diagram may help you better understand what is going on.

### Getting & running the sample

```
git clone https://github.com/timothyparez/avaloniaui-reactive-interaction-sample.git
cd avaloniaui-reactive-interaction-sample
dotnet run
```



