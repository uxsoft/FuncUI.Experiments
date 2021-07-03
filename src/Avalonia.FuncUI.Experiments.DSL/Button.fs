module Avalonia.FuncUI.Experiments.DSL.Button

open System.Windows.Input 
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.ContentControl
open Avalonia.Interactivity
open Avalonia.Input
open Avalonia.FuncUI.Builder
 
type ButtonBuilder<'t when 't :> Button>() =
    inherit ContentControlBuilder<'t>()
    
    [<CustomOperation("clickMode")>] 
    member _.clickMode<'t>(x: DSLElement<'t>, value: ClickMode) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ClickMode>(Button.ClickModeProperty, value, ValueNone) ]
        
    [<CustomOperation("command")>] 
    member _.command<'t>(x: DSLElement<'t>, value: ICommand) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ICommand>(Button.CommandProperty, value, ValueNone) ]
        
    [<CustomOperation("hotKey")>] 
    member _.hotKey<'t>(x: DSLElement<'t>, value: KeyGesture) =
        x @@ [ AttrBuilder<'t>.CreateProperty<KeyGesture>(Button.HotKeyProperty, value, ValueNone) ]
        
    [<CustomOperation("commandParameter")>] 
    member _.commandParameter<'t>(x: DSLElement<'t>, value: obj) =
        x @@ [ AttrBuilder<'t>.CreateProperty<obj>(Button.CommandParameterProperty, value, ValueNone) ]
        
    [<CustomOperation("isDefault")>] 
    member _.isDefault<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Button.IsDefaultProperty, value, ValueNone) ]
        
    [<CustomOperation("isPressed")>] 
    member _.isPressed<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Button.IsPressedProperty, value, ValueNone) ]
        
    [<CustomOperation("onIsPressedChanged")>] 
    member _.onIsPressedChanged<'t>(x: DSLElement<'t>, func: bool -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<bool>(Button.IsPressedProperty, func) ]
        
    [<CustomOperation("onClick")>] 
    member _.onClick<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(Button.ClickEvent, func) ]