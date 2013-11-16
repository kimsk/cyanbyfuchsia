namespace FSharpVm

type MainPageViewModel() =
    inherit ViewModelBase()
    let mutable _count = 0

    member x.Count 
        with get() = _count
        and set count = 
            _count <- count
            x.OnPropertyChanged "Count"

    member x.Increase = 
        new RelayCommand ((fun canExecute -> true), 
            (fun action -> x.Count <- x.Count + 1)) 

    member x.Decrease = 
        new RelayCommand ((fun canExecute -> true), 
            (fun action -> x.Count <- x.Count - 1)) 

