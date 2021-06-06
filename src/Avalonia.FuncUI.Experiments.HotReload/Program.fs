namespace FuncUI.Experiments

open Avalonia.Controls
open Avalonia.FuncUI.Types
open Avalonia.Styling
open Elmish
open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Input
open Avalonia.FuncUI
open Avalonia.FuncUI.VirtualDom
open Avalonia.FuncUI.Elmish
open Avalonia.FuncUI.Components.Hosts

type HotHostControl<'TModel, 'TMsg, 'TView when 'TModel: equality and 'TView :> IView>(
        init : unit -> 'TModel * Cmd<'TMsg>,
        update : 'TMsg -> 'TModel -> 'TModel * Cmd<'TMsg>,
        view : 'TModel -> Dispatch<'TMsg> -> 'TView
    ) as this =
    inherit ContentControl()

    do
        Elmish.Program.mkProgram init update view
        |> Program.withTrace (fun a b -> ())
        |> Program.withHost this
        |> Program.run
    
    let mutable lastViewElement : IView option = None

    let update (nextViewElement : IView option) : unit =
        VirtualDom.updateRoot (this, lastViewElement, nextViewElement)
        lastViewElement <- nextViewElement

    interface IStyleable with
        member this.StyleKey = typeof<ContentControl>

    interface IViewHost with
        member this.Update next =
            update next

type MainWindow() as this =
    inherit Window()
    do
        base.Title <- "FuncUI.Experiments"
        base.Width <- 400.0
        base.Height <- 400.0
        
        this.Content <-
            HotHostControl(
                Counter.init,
                Counter.update,
                Counter.view) 
        //this.VisualRoot.VisualRoot.Renderer.DrawFps <- true
        //this.VisualRoot.VisualRoot.Renderer.DrawDirtyRects <- true

        
type App() =
    inherit Application()
    
    override this.Initialize() =
        this.Styles.Load "avares://Avalonia.Themes.Default/DefaultTheme.xaml"
        this.Styles.Load "avares://Avalonia.Themes.Default/Accents/BaseDark.xaml"

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktopLifetime ->
            desktopLifetime.MainWindow <- MainWindow()
        | _ -> ()

module Program =

    [<EntryPoint>]
    let main(args: string[]) =
        HotReload.test()
        
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .UseSkia()
            .StartWithClassicDesktopLifetime(args)