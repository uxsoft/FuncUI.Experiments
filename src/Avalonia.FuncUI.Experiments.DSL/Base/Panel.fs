module Avalonia.FuncUI.Experiments.DSL.Panel

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
open Avalonia.Media.Immutable
open Avalonia.Media
open Avalonia.FuncUI.Experiments.DSL.Control

type PanelBuilder<'t when 't :> Panel>() =
    inherit ControlBuilder<'t>()

    [<CustomOperation("children")>]
    member _.children<'t>(x: IAttr<'t> list, value: IView list) =
        let getter : ('t -> obj) = (fun control -> control.Children :> obj)
        x @ [ AttrBuilder<'t>.CreateContentMultiple("Children", ValueSome getter, ValueNone, value) ]
        
    [<CustomOperation("background")>]
    member _.background<'t>(x: IAttr<'t> list, value: IBrush) =
        x @ [ AttrBuilder<'t>.CreateProperty<IBrush>(Panel.BackgroundProperty, value, ValueNone) ]
        