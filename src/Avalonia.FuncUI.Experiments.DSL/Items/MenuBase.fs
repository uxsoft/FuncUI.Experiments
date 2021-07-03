module Avalonia.FuncUI.Experiments.DSL.MenuBase

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.SelectingItemsControl
open Avalonia.Interactivity
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Types
 
type MenuBaseBuilder<'t when 't :> MenuBase>() =
    inherit SelectingItemsControlBuilder<'t>()
        
    member _.onMenuOpened<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription(MenuBase.MenuOpenedEvent, func) ]
        
    member _.onMenuClosed<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription(MenuBase.MenuClosedEvent, func) ]