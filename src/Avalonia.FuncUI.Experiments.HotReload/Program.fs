module FuncUI.Experiments.Program

open System.Text.Json
open Avalonia.Controls
open Elmish
open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.FuncUI
open Avalonia.FuncUI.Elmish
open Avalonia.FuncUI.Components.Hosts
open FuncUI.Experiments.Counter
open Live.Avalonia

let transferState<'t> oldState =
    try
        let json = JsonSerializer.Serialize oldState
        let state = JsonSerializer.Deserialize<'t> json        
        match box state with
        | null -> None
        | _ -> Some (state, [])
    with _ -> None

type MainControl(parent: Window) as this =
    inherit HostControl()
    do
        let hotInit () =
            match transferState<Model> parent.DataContext with
            | Some newState ->
                System.Console.WriteLine $"Restored state %O{newState}"
                newState
            | None -> Counter.init ()
        
        Elmish.Program.mkProgram hotInit Counter.update Counter.view
        |> Program.withHost this
        |> Program.withTrace (fun msg state -> parent.DataContext <- state)
        |> Program.run

type App() =
    inherit Application()
    
    interface ILiveView with
        member _.CreateView(window: Window) =
            MainControl(window) :> obj

    override this.Initialize() =
        this.Styles.Load "avares://Avalonia.Themes.Default/DefaultTheme.xaml"
        this.Styles.Load "avares://Avalonia.Themes.Default/Accents/BaseDark.xaml"

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktopLifetime ->
            let window = new LiveViewHost(this, fun msg -> printfn $"%s{msg}")
            window.Title <- "Hot Reload Demo"
            window.StartWatchingSourceFilesForHotReloading();
            window.Show();
            base.OnFrameworkInitializationCompleted()
        | _ -> ()

[<EntryPoint>]
let main(args: string[]) =
    AppBuilder
        .Configure<App>()
        .UsePlatformDetect()
        .UseSkia()
        .StartWithClassicDesktopLifetime(args)