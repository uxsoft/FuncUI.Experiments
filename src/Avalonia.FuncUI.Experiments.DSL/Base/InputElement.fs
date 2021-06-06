module Avalonia.FuncUI.Experiments.DSL.InputElement

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Layoutable
open Avalonia.FuncUI.Types
open Avalonia.Interactivity
open Avalonia.FuncUI.Builder
open Avalonia.Input

type InputElementBuilder<'t when 't :> InputElement>() =
    inherit LayoutableBuilder<'t>()
    
    [<CustomOperation("focusable")>]
    member _.focusable<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [  AttrBuilder<'t>.CreateProperty<bool>(InputElement.FocusableProperty, value, ValueNone) ]
        
    [<CustomOperation("isEnabled")>]
    member _.isEnabled<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [  AttrBuilder<'t>.CreateProperty<bool>(InputElement.IsEnabledProperty, value, ValueNone) ]

    [<CustomOperation("cursor")>]
    member _.cursor<'t>(x: DSLElement<'t>, cursor: Cursor) =
        x @@ [  AttrBuilder<'t>.CreateProperty<Cursor>(InputElement.CursorProperty, cursor, ValueNone) ]
  
    [<CustomOperation("isHitTestVisible")>]
    member _.isHitTestVisible<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [  AttrBuilder<'t>.CreateProperty<bool>(InputElement.IsHitTestVisibleProperty, value, ValueNone) ]
        
    [<CustomOperation("onGotFocus")>]
    member _.onGotFocus<'t>(x: DSLElement<'t>, func: GotFocusEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<GotFocusEventArgs>(InputElement.GotFocusEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onLostFocus")>]
    member _.onLostFocus<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(InputElement.LostFocusEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onKeyDown")>]
    member _.onKeyDown<'t>(x: DSLElement<'t>, func: KeyEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<KeyEventArgs>(InputElement.KeyDownEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onKeyUp")>]
    member _.onKeyUp<'t>(x: DSLElement<'t>, func: KeyEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<KeyEventArgs>(InputElement.KeyUpEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onTextInput")>]
    member _.onTextInput<'t>(x: DSLElement<'t>, func: TextInputEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<TextInputEventArgs>(InputElement.TextInputEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onPointerEnter")>]
    member _.onPointerEnter<'t>(x: DSLElement<'t>, func: PointerEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<PointerEventArgs>(InputElement.PointerEnterEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onPointerLeave")>]
    member _.onPointerLeave<'t>(x: DSLElement<'t>, func: PointerEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<PointerEventArgs>(InputElement.PointerLeaveEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onPointerMoved")>]
    member _.onPointerMoved<'t>(x: DSLElement<'t>, func: PointerEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<PointerEventArgs>(InputElement.PointerMovedEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onPointerPressed")>]
    member _.onPointerPressed<'t>(x: DSLElement<'t>, func: PointerPressedEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<PointerPressedEventArgs>(InputElement.PointerPressedEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onPointerReleased")>]
    member _.onPointerReleased<'t>(x: DSLElement<'t>, func: PointerReleasedEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<PointerReleasedEventArgs>(InputElement.PointerReleasedEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onPointerCaptureLost")>]
    member _.onPointerCaptureLost<'t>(x: DSLElement<'t>, func: PointerCaptureLostEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<PointerCaptureLostEventArgs>(InputElement.PointerCaptureLostEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onPointerWheelChanged")>]
    member _.onPointerWheelChanged<'t>(x: DSLElement<'t>, func: PointerWheelEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<PointerWheelEventArgs>(InputElement.PointerWheelChangedEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onTapped")>]
    member _.onTapped<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(InputElement.TappedEvent, func, ?subPatchOptions = subPatchOptions) ]
        
    [<CustomOperation("onDoubleTapped")>]
    member _.onDoubleTapped<'t>(x: DSLElement<'t>, func: RoutedEventArgs -> unit, ?subPatchOptions) =
        x @@ [  AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(InputElement.DoubleTappedEvent, func, ?subPatchOptions = subPatchOptions) ]