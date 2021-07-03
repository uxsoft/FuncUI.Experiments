module Avalonia.FuncUI.Experiments.DSL.MenuItem

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.HeaderedSelectingItemsControl
open Avalonia.Input
open Avalonia.Interactivity
open System.Windows.Input
open Avalonia.Controls
open Avalonia.FuncUI.Builder

type MenuItemBuilder<'t when 't :> MenuItem>() =
    inherit HeaderedSelectingItemsControlBuilder<'t>()
    
    [<CustomOperation("command")>]
    member _.command<'t>(x: DSLElement<'t>, command: ICommand) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ICommand>(MenuItem.CommandProperty, command, ValueNone) ]
        
    [<CustomOperation("commandParameter")>]
    member _.commandParameter<'t>(x: DSLElement<'t>, parameter: obj) =
        x @@ [ AttrBuilder<'t>.CreateProperty<obj>(MenuItem.CommandParameterProperty, parameter, ValueNone) ]
    
    [<CustomOperation("hotKey")>]
    member _.hotKey<'t>(x: DSLElement<'t>, value: KeyGesture) =
        x @@ [ AttrBuilder<'t>.CreateProperty<KeyGesture>(MenuItem.HotKeyProperty, value, ValueNone) ]
    
    [<CustomOperation("icon")>]
    member _.icon<'t>(x: DSLElement<'t>, value: obj) =
        x @@ [ AttrBuilder<'t>.CreateProperty<obj>(MenuItem.IconProperty, value, ValueNone) ]

    [<CustomOperation("inputGesture")>]
    member _.inputGesture<'t>(x: DSLElement<'t>, value: KeyGesture) =
        x @@ [ AttrBuilder<'t>.CreateProperty<KeyGesture>(MenuItem.InputGestureProperty, value, ValueNone) ]
    
    [<CustomOperation("isSelected")>]
    member _.isSelected<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(MenuItem.IsSelectedProperty, value, ValueNone) ]

    [<CustomOperation("onIsSelectedChanged")>]
    member _.onIsSelectedChanged<'t>(x: DSLElement<'t>, func: bool -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<bool>(MenuItem.IsSelectedProperty, func) ]
        
    [<CustomOperation("isSubMenuOpen")>]
    member _.isSubMenuOpen<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(MenuItem.IsSubMenuOpenProperty, value, ValueNone) ]
        
    [<CustomOperation("onIsSubMenuOpenChanged")>]
    member _.onIsSubMenuOpenChanged<'t>(x: DSLElement<'t>, func: bool -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<bool>(MenuItem.IsSubMenuOpenProperty, func) ]
        
    [<CustomOperation("onClick")>]
    member _.onClick<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(MenuItem.ClickEvent, func) ]
        
    [<CustomOperation("onPointerEnterItem")>]
    member _.onPointerEnterItem<'t>(x: DSLElement<'t>, func: PointerEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<PointerEventArgs>(MenuItem.PointerEnterItemEvent, func) ]
        
    [<CustomOperation("onPointerLeaveItem")>]
    member _.onPointerLeaveItem<'t>(x: DSLElement<'t>, func: PointerEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<PointerEventArgs>(MenuItem.PointerLeaveItemEvent, func) ]
        
    [<CustomOperation("onSubMenuOpened")>]
    member _.onSubMenuOpened<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(MenuItem.SubmenuOpenedEvent, func) ]