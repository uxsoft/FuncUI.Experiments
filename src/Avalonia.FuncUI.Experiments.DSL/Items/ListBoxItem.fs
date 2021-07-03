module Avalonia.FuncUI.Experiments.DSL.ListBoxItem

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.ContentControl
open Avalonia.FuncUI.Builder
 
type ListBoxItemBuilder<'t when 't :> ListBoxItem>() =
    inherit ContentControlBuilder<'t>()

    [<CustomOperation("isSelected")>] 
    member _.isSelected<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ListBoxItem.IsSelectedProperty, value, ValueNone) ]

    [<CustomOperation("onIsSelectedChanged")>] 
    member _.onIsSelectedChanged<'t>(x: DSLElement<'t>, func: bool -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<bool>(ListBoxItem.IsSelectedProperty, func) ]