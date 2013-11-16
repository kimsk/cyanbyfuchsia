namespace FSharpVm

open System
open System.Windows.Input
open System.ComponentModel

// from F# Windows App (WPF, MVVM) template by Daniel Mohl
// http://visualstudiogallery.msdn.microsoft.com/ad49fd5c-930c-4fe6-a30e-2d0d6778c565?SRC=VSIDE
type RelayCommand (canExecute:(obj -> bool), action:(obj -> unit)) =
    let event = new DelegateEvent<EventHandler>()
    interface ICommand with
        [<CLIEvent>]
        member x.CanExecuteChanged = event.Publish
        member x.CanExecute arg = canExecute(arg)
        member x.Execute arg = action(arg)