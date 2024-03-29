﻿namespace Avalonia.FuncUI.Experiments.TestApp

open Avalonia.FuncUI.Hosts
open Elmish
open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.FuncUI
open Avalonia.FuncUI.Elmish

type MainWindow() as this =
    inherit HostWindow()
    do
        base.Title <- "Avalonia.FuncUI.Experiments.TestApp"
        base.Width <- 400.0
        base.Height <- 400.0
        
        Elmish.Program.mkSimple (fun () -> AppLogic.init) AppLogic.update AppLogic.view
        |> Program.withHost this
        |> Program.run

        
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
    let main(args: string array) =
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .UseSkia()
            .StartWithClassicDesktopLifetime(args)