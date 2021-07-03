module Avalonia.FuncUI.Experiments.DSL.TabItem

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.HeaderedContentControl
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
 
type TabItemBuilder<'t when 't :> TabItem>() =
    inherit HeaderedContentControlBuilder<'t>()

    [<CustomOperation("tabStripPlacement")>] 
    member _.tabStripPlacement<'t>(x: DSLElement<'t>, placement: Dock) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Dock>(TabItem.TabStripPlacementProperty, placement, ValueNone) ]
    
    [<CustomOperation("isSelected")>] 
    member _.isSelected<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(TabItem.IsSelectedProperty, value, ValueNone) ]
        
    [<CustomOperation("onIsSelectedChanged")>] 
    member _.onIsSelectedChanged<'t>(x: DSLElement<'t>, func: bool -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<bool>(TabItem.IsSelectedProperty, func) ]