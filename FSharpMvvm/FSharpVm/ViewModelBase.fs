namespace FSharpVm

open System.ComponentModel

// from F# Windows App (WPF, MVVM) template by Daniel Mohl
// http://visualstudiogallery.msdn.microsoft.com/ad49fd5c-930c-4fe6-a30e-2d0d6778c565?SRC=VSIDE
type ViewModelBase() =
    let propertyChangedEvent = new DelegateEvent<PropertyChangedEventHandler>()
    interface INotifyPropertyChanged with
        [<CLIEvent>]
        member x.PropertyChanged = propertyChangedEvent.Publish
    member x.OnPropertyChanged propertyName = 
        propertyChangedEvent.Trigger([| x; new PropertyChangedEventArgs(propertyName) |])
