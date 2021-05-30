namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module Button =
    open System.Windows.Input 
    open Avalonia.Controls
    open Avalonia.Interactivity
    open Avalonia.Input
    open Avalonia.FuncUI.Builder
    open Avalonia.FuncUI.Types
    
    let create (attrs: IAttr<Button> list): IView<Button> =
        ViewBuilder.Create<Button>(attrs)
     
    type Button with

        static member clickMode<'t when 't :> Button>(value: ClickMode) =
            AttrBuilder<'t>.CreateProperty<ClickMode>(Button.ClickModeProperty, value, ValueNone)
            
        static member command<'t when 't :> Button>(value: ICommand) =
            AttrBuilder<'t>.CreateProperty<ICommand>(Button.CommandProperty, value, ValueNone)
            
        static member hotKey<'t when 't :> Button>(value: KeyGesture) =
            AttrBuilder<'t>.CreateProperty<KeyGesture>(Button.HotKeyProperty, value, ValueNone)
            
        static member commandParameter<'t when 't :> Button>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(Button.CommandParameterProperty, value, ValueNone)
            
        static member isDefault<'t when 't :> Button>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Button.IsDefaultProperty, value, ValueNone)
            
        static member isPressed<'t when 't :> Button>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Button.IsPressedProperty, value, ValueNone)
            
        static member onIsPressedChanged<'t when 't :> Button>(func: bool -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<bool>(Button.IsPressedProperty, func, ?subPatchOptions = subPatchOptions)
            
        static member onClick<'t when 't :> Button>(func: RoutedEventArgs -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(Button.ClickEvent, func, ?subPatchOptions = subPatchOptions)