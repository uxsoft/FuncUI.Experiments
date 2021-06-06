module Avalonia.FuncUI.Experiments.DSL.DockPanel

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Panel
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type DockPanelBuilder<'t when 't :> DockPanel>() =
    inherit PanelBuilder<'t>()
    
    [<CustomOperation("lastChildFill")>]
    member _.lastChildFill<'t>(x: DSLElement<'t>, fill: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(DockPanel.LastChildFillProperty, fill, ValueNone) ]